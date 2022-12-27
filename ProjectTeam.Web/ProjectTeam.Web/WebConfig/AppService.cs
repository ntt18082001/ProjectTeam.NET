using AutoMapper;
using FluentAssertions.Common;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using ProjectTeam.Data;
using ProjectTeam.Data.Serivces;
using ProjectTeam.Web.Common.Mailer;
using ProjectTeam.Web.Components.MainNavBar;


namespace ProjectTeam.Web.WebConfig
{
	public static class AppService
	{
		public static void AddAppService(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddHttpContextAccessor();
			services.AddDbContext<WebAppDbContext>(option =>
            {
				option.UseSqlServer(configuration.GetConnectionString("Database"));

            });

            services.AddControllersWithViews();

			services.Configure<RazorViewEngineOptions>(config =>
			{
				// path: /Components/{component-name}/Default.cshtml
				config.ViewLocationFormats.Add("/{0}.cshtml");
				config.AreaViewLocationFormats.Add("Areas/Admin/{0}.cshtml");
			});

			// Đăng ký repository
			services.AddScoped<GenericRepository>();

			// Cấu hình AutoMapper
			var mapperConfig = new MapperConfiguration(config =>
			{
				config.AddProfile(new AutoMapperProfile());
			});
			IMapper mapper = mapperConfig.CreateMapper();
			services.AddSingleton(mapper);

			// Khởi tạo dữ liệu thanh menu
			NavBarViewModel navBar = new();
			navBar.AddListNavBar();
			services.AddSingleton(navBar);

			// Khởi tạo thông tin mail
			AppMailConfiguration mailConfig = new();
			mailConfig.LoadFromConfig(configuration);
			services.AddSingleton(mailConfig);
		}
	}
}
