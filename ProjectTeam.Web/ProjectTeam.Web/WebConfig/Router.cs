namespace ProjectTeam.Web.WebConfig
{
	public static class Router
	{
		public static void MapAppRoute(this IEndpointRouteBuilder endpoints)
		{
			endpoints.MapControllerRoute(
					name: "login",
					pattern: "/login",
					defaults: new
					{
						controller = "Account",
						action = "Login"
					});

			endpoints.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");
		}
	}
}
