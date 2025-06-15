using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.Data.Models;
using SPP.ViewModels;

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

        public async Task<IActionResult> Index()
        {
            var products = await context.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                ImageUrl = x.ImageUrl
            }).ToListAsync();

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

            // Get or create user's active cart
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

            // Check if product already in cart
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
    }
}

