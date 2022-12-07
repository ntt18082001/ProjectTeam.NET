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
					CodePage = "HomeIndex",
					//Permission = AuthConst.NO_PERMISSION
				},
				new MenuItem
				{
					Action = "Privacy",
					Controller = "Home",
					DisplayText = "Privacy",
					Icon = "mdi-home",
					CodePage = "PrivacyIndex",
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
							Action = "Test",
							Controller = "Test",
							DisplayText = "Test view",
							Icon = "fa-box",
							CodePage = "TestView"
							//Permission = AuthConst.AppProducts.VIEW_LIST
						}
					}
				},
				new MenuItem
				{
					DisplayText = "Game",
					Icon = "mdi-hexagon-slice-5",
					//Permission = AuthConst.AppOrder.VIEW_LIST
					ChildrenItems = new MenuItem[]
					{
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
