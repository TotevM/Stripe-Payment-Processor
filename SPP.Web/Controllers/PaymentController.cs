﻿using Microsoft.AspNetCore.Mvc;

namespace SPP.Web.Controllers
{
	public class PaymentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
