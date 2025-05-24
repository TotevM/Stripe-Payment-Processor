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
            //// Check if the product exists
            //var product = await context.Products.FindAsync(id);
            //if (product == null)
            //{
            //    return NotFound();
            //}

            //// Check if the user exists
            //string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //if (string.IsNullOrEmpty(userId))
            //{
            //    return RedirectToAction("Login", "Account", new { returnUrl = Url.Action("Index", "Product") });
            //}

            ////check if the cart exists
            //Order? cart = await context.Orders.OrderByDescending(c => c.CreatedAt)
            //    .FirstOrDefaultAsync(c => c.UserId == userId);

            ////if the cart doesnt exists, create a cart and add the product to it
            //if (cart == null)
            //{
            //    cart = new Order
            //    {
            //        UserId = userId,
            //        CreatedAt = DateTime.UtcNow,
            //        Items = new List<OrderItem>(),
            //    };

            //    var orderItem = new OrderItem
            //    {
            //        OrderId = Guid.NewGuid(),
            //        ProductId = id,
            //        Quantity = 1
            //    };

            //    cart.Items.Add(orderItem);
            //}

            ////if cart exists, check if the product exists in the cart
            //if (cart != null)
            //{
            //    var orderItem = new OrderItem
            //    {
            //        OrderId = Guid.NewGuid(),
            //        ProductId = id,
            //        Quantity = 1
            //    };

            //    cart.Items.Add(orderItem);
            //}


            ////var orderItem = new OrderItem
            ////{
            ////    OrderId = Guid.NewGuid(),
            ////    ProductId = product.Id,
            ////    Quantity = 1
            ////};


            //return RedirectToAction(nameof(Index));

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
            }
            else
            {
                cart.OrderItems.Add(new OrderItem
                {
                    Id = Guid.NewGuid(),
                    ProductId = id,
                    Quantity = 1
                });
            }

            await context.SaveChangesAsync();
            return Ok("Product added to cart.");
        }
    }
}

