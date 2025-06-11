using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using SPP.ViewModels;
using Stripe.Checkout;
using System.Globalization;

namespace SPP.Web.Controllers
{
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
                SuccessUrl = domain + "Checkout/Success",
                CancelUrl = domain + "Checkout/Cancel",

                CustomerEmail=user.Email,
                Customer=user.UserName,
                Mode = "payment",
                //PaymentMethodTypes = new List<string> { "card" },
                LineItems = items.Select(item => new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        Currency = "usd",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = item.Name,
                            Images = item.ImageUrl != null ? new List<string> { domain + item.ImageUrl } : null
                        },
                        UnitAmount = (long)(item.Price * item.Quantity)
                    },
                    Quantity = item.Quantity
                }).ToList(),
            };
            var service= new SessionService();
            Session session = service.Create(options);
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
    }
}
