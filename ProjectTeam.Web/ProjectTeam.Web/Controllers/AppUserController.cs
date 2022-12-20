using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
    public class AppUserController : BaseAdminController
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
