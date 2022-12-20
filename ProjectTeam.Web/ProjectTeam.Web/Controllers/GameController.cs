using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class GameController : BaseAdminController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
