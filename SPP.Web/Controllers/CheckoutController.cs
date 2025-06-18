using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using SPP.ViewModels;
using Stripe.Checkout;

namespace SPP.Web.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {

        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public CheckoutController(ApplicationDbContext _context, UserManager<ApplicationUser> _userManager)
        {
            context = _context;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

            if (cart == null)
                return NotFound();

            List<CartItemViewModel> items = cart.OrderItems.Select(oi => new CartItemViewModel
            {
                Id = oi.ProductId,
                Name = oi.Product.Name,
                ImageUrl = oi.Product.ImageUrl,
                Price = Math.Round(oi.Product.Price, 2),
                Quantity = oi.Quantity
            }).ToList();

            var domain = "https://localhost:7036/";

            SessionCreateOptions options = new SessionCreateOptions
            {
                SuccessUrl = domain + "Checkout/OrderConfirmation",
                CancelUrl = domain + "Checkout/Cancel",

                CustomerEmail = user.Email,
                Mode = "payment",
                LineItems = items.Select(item => new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Name,
                            Images = item.ImageUrl != null ? new List<string> { item.ImageUrl } : null
                        },
                        UnitAmount = (long)Math.Round(item.TotalPrice * 100)
                    },
                    Quantity = item.Quantity
                }).ToList(),
            };

            var service = new SessionService();
            Session session = service.Create(options);

            TempData["Session"] = session.Id;

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }

        public IActionResult OrderConfirmation()
        {
            var service = new SessionService();

            Session session = service.Get(TempData["Session"]!.ToString());

            if (session.PaymentStatus == "paid")
            {
                return RedirectToAction("Success", "Checkout");
            }
            return View("PaymentFailed");
        }

        public async Task<IActionResult> Success() 
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            Order? order = await context.Orders.Where(x => !x.IsPaid && x.UserId==user.Id).FirstOrDefaultAsync();
            
            if (order==null)
            {
                return View("PaymentFailed");
            }

            order.PaidAt = DateTime.Now;
            order.IsPaid = true;
            await context.SaveChangesAsync();

            return View();
        }
    }
}
