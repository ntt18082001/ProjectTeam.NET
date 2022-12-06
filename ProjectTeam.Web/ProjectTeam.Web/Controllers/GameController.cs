using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class GameController : Controller
	{
		public IActionResult Index()
		{
			ViewBag.CodePage = "IndexGame";
			return View();
		}
	}
}
