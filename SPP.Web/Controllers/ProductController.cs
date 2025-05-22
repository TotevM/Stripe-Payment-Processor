using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.ViewModels;
using System.Security.Claims;

namespace SPP.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext _context)
        {
            context = _context;
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

        public async Task<IActionResult> AddToCart(Guid id)
        {
            // Check if the product exists
            var product = await context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            // Check if the user exists
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Product") });
            }

            // Get or create cart
            var cart = await context.Orders
                .Include(c => c.Items)
                .ThenInclude(i => i.Product)
                .FirstOrDefaultAsync(c => c.UserId == userId && c.FinalizedAt == default);

            if (cart == null)
            {
                cart = new Cart
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow,
                    Items = new List<OrderItem>()
                };
                context.Orders.Add(cart);
            }

            // Check if product already exists in cart
            var existingItem = cart.Items.FirstOrDefault(i => i.ProductId == product.Id);
            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cart.Items.Add(new OrderItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = product.Id,
                    OrderId = cart.Id,
                    Quantity = 1,
                    PriceAtPurchase = product.Price
                });
            }

            await context.SaveChangesAsync();
            TempData["SuccessMessage"] = $"{product.Name} added to cart successfully!";
            return RedirectToAction(nameof(Index));
        }
    }
}
