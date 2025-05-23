﻿using Microsoft.AspNetCore.Mvc;
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

            //check if the cart exists
            Order? cart = await context.Orders.OrderByDescending(c => c.CreatedAt)
                .FirstOrDefaultAsync(c => c.UserId == userId);

            //if the cart doesnt exists, create a cart and add the product to it
            if (cart == null)
            {
                cart = new Order
                {
                    UserId = userId,
                    CreatedAt = DateTime.UtcNow,
                    Items = new List<OrderItem>(),
                };

                var orderItem = new OrderItem
                {
                    OrderId = Guid.NewGuid(),
                    ProductId = id,
                    Quantity = 1
                };

                cart.Items.Add(orderItem);
            }

            //if cart exists, check if the product exists in the cart
            if (cart != null)
            {
                var orderItem = new OrderItem
                {
                    OrderId = Guid.NewGuid(),
                    ProductId = id,
                    Quantity = 1
                };

                cart.Items.Add(orderItem);
            }


            //var orderItem = new OrderItem
            //{
            //    OrderId = Guid.NewGuid(),
            //    ProductId = product.Id,
            //    Quantity = 1
            //};


            return RedirectToAction(nameof(Index));
        }
    }
}
