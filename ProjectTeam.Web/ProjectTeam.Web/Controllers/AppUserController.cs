using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
    public class AppUserController : BaseAdminController
    {
		public AppUserController(IMapper mapper) : base(mapper) { }

		public IActionResult Index()
        {
            return View();
        }
    }
}
