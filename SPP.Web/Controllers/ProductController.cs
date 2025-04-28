using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPP.ViewModels;

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
    }
}
