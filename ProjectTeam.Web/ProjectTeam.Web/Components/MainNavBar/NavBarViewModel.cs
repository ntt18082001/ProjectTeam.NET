using ProjectTeam.Web.WebConfig.Consts;

namespace ProjectTeam.Web.Components.MainNavBar
{
	public class NavBarViewModel
	{
		public NavBarViewModel()
		{
			Items = new List<MenuItem>();
		}
		public List<MenuItem> Items { get; set; }
		public void AddListNavBar()
		{
			Items.AddRange(new MenuItem[]
			{
				new MenuItem
				{
					Action = "Index",
					Controller = "Home",
					DisplayText = "Dashboard",
					Icon = "mdi-home",
					CodePage = CodePageConst.Home.HOME_CODE_PAGE,
					//Permission = AuthConst.NO_PERMISSION
				},
                new MenuItem
                {
                    DisplayText = "Tài khoản",
                    Icon = "mdi-account-group",
					//Permission = AuthConst.AppOrder.VIEW_LIST
					ChildrenItems = new MenuItem[]
                    {
                        new MenuItem
                        {
                            Action = "Index",
                            Controller = "AppUser",
                            DisplayText = "Quản lý tài khoản",
                            Icon = "fa-box",
                            CodePage = CodePageConst.AppUser.INDEX_USER_CODE_PAGE
							//Permission = AuthConst.AppProducts.VIEW_LIST
						},
						new MenuItem
						{
							Action = "Index",
							Controller = "AppRole",
							DisplayText = "Quản lý phân quyền",
							Icon = "fa-box",
							CodePage = CodePageConst.AppRole.INDEX_ROLE_CODE_PAGE
							//Permission = AuthConst.AppProducts.VIEW_LIST
						}
					}
                },
            });

		}
	}

	public class MenuItem
	{
		public MenuItem()
		{
			//Permission = AuthConst.NO_PERMISSION;
		}
		public string Action { get; set; }
		public string Controller { get; set; }
		public string DisplayText { get; set; }
		public string Icon { get; set; }
		public int Permission { get; set; }
		public string CodePage { get; set; }
		public MenuItem[] ChildrenItems { get; set; }
	}
}
