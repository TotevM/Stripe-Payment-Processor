using Microsoft.AspNetCore.Mvc;

namespace SPP.Web.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
