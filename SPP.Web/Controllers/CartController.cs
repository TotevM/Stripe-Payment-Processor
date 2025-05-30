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
                    Price = oi.Product.Price,
                    Quantity = oi.Quantity
                }).ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(Guid id)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

            if (cart == null)
                return NotFound("Cart not found");

            var item = cart.OrderItems.FirstOrDefault(i => i.ProductId == id);
            if (item == null)
                return NotFound("Item not found in cart");

            context.OrderItems.Remove(item);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateQuantity([FromBody] UpdateQuantityDto model)
        {
            if (model.Quantity < 1)
                return BadRequest("Quantity must be at least 1");

            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var cart = await context.Orders
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

            var subtotal = cart.OrderItems.Sum(i => i.Product.Price * i.Quantity);

            var tax = (double)subtotal * TaxRate/100;
            var total = (double)subtotal + tax;

            return Json(new
            {
                success = true,
                subtotal = subtotal.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                tax = tax.ToString("C", CultureInfo.GetCultureInfo("en-US")),
                total = total.ToString("C", CultureInfo.GetCultureInfo("en-US"))
            });
        }

    }
}