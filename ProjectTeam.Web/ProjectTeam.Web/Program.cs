using Microsoft.AspNetCore.Mvc.Razor;
using ProjectTeam.Web.WebConfig;
using ProjectTeam.Web.WebConfig.Consts;

var builder = WebApplication.CreateBuilder(args);

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

app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
	endpoints.MapAppRoute();
});

app.Run();