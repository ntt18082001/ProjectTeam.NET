using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class TestController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
