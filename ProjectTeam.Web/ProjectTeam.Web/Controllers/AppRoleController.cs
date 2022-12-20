using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTeam.Web.Controllers
{
	public class AppRoleController : BaseAdminController
	{
		public AppRoleController(IMapper mapper) : base(mapper) { }
		public IActionResult Index()
		{
			return View();
		}
	}
}
