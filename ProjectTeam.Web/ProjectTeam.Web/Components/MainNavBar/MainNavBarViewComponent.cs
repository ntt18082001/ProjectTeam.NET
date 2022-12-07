using Microsoft.AspNetCore.Mvc;
using static ProjectTeam.Web.Components.MainNavBar.NavBarViewModel;

namespace ProjectTeam.Web.Components.MainNavBar
{
	public class MainNavBarViewComponent : ViewComponent
	{
		readonly NavBarViewModel _navBar;
		public MainNavBarViewComponent(NavBarViewModel navBar)
		{
			_navBar = navBar;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View(_navBar);
		}
	}
}
