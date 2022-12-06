using Microsoft.AspNetCore.Mvc.Razor;

namespace ProjectTeam.Web.WebConfig
{
	public static class AppService
	{
		public static void AddAppService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddControllersWithViews();

			services.Configure<RazorViewEngineOptions>(config =>
			{
				// path: /Components/{component-name}/Default.cshtml
				config.ViewLocationFormats.Add("/{0}.cshtml");
				config.AreaViewLocationFormats.Add("Areas/Admin/{0}.cshtml");
			});
		}
	}
}
