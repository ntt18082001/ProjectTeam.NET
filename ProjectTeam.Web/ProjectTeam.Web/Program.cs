using Microsoft.AspNetCore.Mvc.Razor;
using ProjectTeam.Web.WebConfig;
using ProjectTeam.Web.WebConfig.Consts;

var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.Configure<RazorViewEngineOptions>(config =>
//{
//	// path: /Components/{component-name}/Default.cshtml
//	config.ViewLocationFormats.Add("/{0}.cshtml");
//	config.AreaViewLocationFormats.Add("Areas/Admin/{0}.cshtml");
//});

builder.Services.AddAppService(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
	endpoints.MapAppRoute();

	endpoints.MapControllerRoute(
				name: "Client",
				pattern: AppConst.LOGIN_PATH,
				defaults: new
				{
					controller = "Auth",
					action = "Login",

				});
});

app.Run();