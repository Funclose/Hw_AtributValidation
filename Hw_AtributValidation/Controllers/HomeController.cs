using Hw_AtributValidation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Hw_AtributValidation.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(Person person)
		{
			if(ModelState.IsValid)
			{
				return Content("Ok");
			}
			return View(person);
		}
		[AllowAnonymous]
		public IActionResult CheckUniqueUserName(string userName)
		{
			if(userName.Equals("Admin"))
			{
				return Json(false);
			}
			return Json(true);
		}
	}
}
