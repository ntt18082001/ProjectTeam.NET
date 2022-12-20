using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class TestController : BaseAdminController
    {
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Test()
		{
			return View();
		}
	}
}
