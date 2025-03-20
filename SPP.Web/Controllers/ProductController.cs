using Microsoft.AspNetCore.Mvc;

namespace SPP.Web.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
