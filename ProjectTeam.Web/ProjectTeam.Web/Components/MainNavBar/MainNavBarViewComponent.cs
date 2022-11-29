using Microsoft.AspNetCore.Mvc;
using static ProjectTeam.Web.Components.MainNavBar.NavBarViewModel;

namespace ProjectTeam.Web.Components.MainNavBar
{
	public class MainNavBarViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var navBar = new NavBarViewModel();
			navBar.Items.AddRange(new MenuItem[]
			{
				new MenuItem
				{
					Action = "Index",
					Controller = "Home",
					DisplayText = "Dashboard",
					Icon = "mdi-home",
					//Permission = AuthConst.NO_PERMISSION
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "Test",
					DisplayText = "Test hihi",
					Icon = "mdi-hexagon-slice-5",
					//Permission = AuthConst.AppOrder.VIEW_LIST
				},
			});
			return View(navBar);
		}
	}
}
