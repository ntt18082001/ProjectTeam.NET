using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectTeam.Web.Models;
using ProjectTeam.Web.WebConfig.Consts;
using System.Diagnostics;

namespace ProjectTeam.Web.Controllers
{
	[Authorize(AuthenticationSchemes = AppConst.COOKIES_AUTH)]
	public class HomeController : BaseAdminController
    {
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, IMapper mapper) : base(mapper)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}