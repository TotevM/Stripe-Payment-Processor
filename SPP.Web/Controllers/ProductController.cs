using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using SPP.ViewModels;
using System.Collections.Generic;

namespace SPP.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public ProductController(ApplicationDbContext _context, UserManager<ApplicationUser> _userManager)
        {
            context = _context;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index(string category)
        {
            List<ProductViewModel> products = new List<ProductViewModel>();
            if (category!=null)
            {
                products = await context.Products.Where(x=>x.Type==category).Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description
                }).ToListAsync();
            }
            else
            {

                products = await context.Products.Select(x => new ProductViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    ImageUrl = x.ImageUrl,
                    Description = x.Description
                }).ToListAsync();
            }

            return View(products);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddToCart(Guid id)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var product = await context.Products
                .FirstOrDefaultAsync(p => p.Id == id && !p.IsDeleted);

            if (product == null)
                return NotFound("Product not found or has been deleted.");

            var cart = await context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefaultAsync(o => o.UserId == user.Id && !o.IsPaid);

            if (cart == null)
            {
                cart = new Order
                {
                    Id = Guid.NewGuid(),
                    UserId = user.Id,
                    IsPaid = false,
                    CreatedAt = DateTime.UtcNow
                };

                context.Orders.Add(cart);
            }

            var existingItem = cart.OrderItems.FirstOrDefault(i => i.ProductId == id);
            if (existingItem != null)
            {
                existingItem.Quantity += 1;
                context.OrderItems.Update(existingItem);
            }
            else
            {
                var newItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = id,
                    OrderId = cart.Id,
                    Quantity = 1
                };
                context.OrderItems.Add(newItem);
            }
            await context.SaveChangesAsync();

            var count = cart.OrderItems.Count;
            return Json(new { success = true, count });
        }

        public async Task<IActionResult> CheckOrders()
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
                return Unauthorized();

            var orders = await context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.Product)
                .Where(o => o.IsPaid)
                .ToListAsync();

            return View(orders);
        }
    }
}

