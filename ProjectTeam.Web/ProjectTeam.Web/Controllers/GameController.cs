using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class GameController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
