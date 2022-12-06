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
					DisplayText = "Test",
					Icon = "mdi-hexagon-slice-5",
					//Permission = AuthConst.AppOrder.VIEW_LIST
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "Test",
							DisplayText = "Test",
							Icon = "fa-box",
							CodePage = "IndexTest"
							//Permission = AuthConst.AppProducts.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "Game",
							DisplayText = "Game",
							Icon = "fa-box",
							CodePage = "IndexGame"
							//Permission = AuthConst.AppProducts.VIEW_LIST
						}
					}
				},
			});
			return View(navBar);
		}
	}
}
