using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using SPP.ViewModels;
using System.Globalization;
using static SPP.Common.AppConstants;

namespace SPP.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public CartController(ApplicationDbContext _context, UserManager<ApplicationUser> _userManager)
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
                return View(new CartViewModel());

            var viewModel = new CartViewModel
            {
                Items = cart.OrderItems.Select(oi => new CartItemViewModel
                {
                    Id = oi.ProductId,
                    Name = oi.Product.Name,
                    ImageUrl = oi.Product.ImageUrl,
                    Price = Math.Round(oi.Product.Price, 2),
                    Quantity = oi.Quantity
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateQuantity([FromBody] UpdateQuantityDto model)
        {
            Order? cart = new();
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            if (model.Quantity == 0)
            {
                cart = await context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

                if (cart == null)
                    return NotFound("Cart not found");

                var currentItem = cart.OrderItems.FirstOrDefault(i => i.ProductId == model.Id);
                if (currentItem == null)
                    return NotFound("Item not found in cart");

                context.OrderItems.Remove(currentItem);
                await context.SaveChangesAsync();
            }
            else
            {
                cart = await context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

                if (cart == null)
                    return NotFound("Cart not found");

                var item = cart.OrderItems.FirstOrDefault(i => i.ProductId == model.Id);
                if (item == null)
                    return NotFound("Item not found in cart");

                item.Quantity = model.Quantity;
                await context.SaveChangesAsync();


            }
                var subtotal = cart.OrderItems.Sum(i => i.Product.Price * i.Quantity);
                var tax = subtotal * TaxRate / 100;
                var total = subtotal + tax;

            return Json(new
            {
                success = true,
                subtotal = subtotal.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                tax = tax.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                total = total.ToString("C", CultureInfo.GetCultureInfo("en-US"))
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetItemCount()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

            if (cart == null)
                return Json(0);

            var count = cart.OrderItems.Count;
            return Json(count);
        }
    }
}