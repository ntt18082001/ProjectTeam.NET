using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.IdentityModel.Tokens;
using ProjectTeam.Data.Entities;
using ProjectTeam.Data.Serivces;
using ProjectTeam.Share.Const;
using ProjectTeam.Web.ViewModels.Account;
using ProjectTeam.Web.WebConfig;
using ProjectTeam.Web.WebConfig.Consts;
using System.Security.Claims;
using AppConst = ProjectTeam.Web.WebConfig.Consts.AppConst;

namespace ProjectTeam.Web.Controllers
{
	public class AccountController : BaseAdminController
	{
		readonly GenericRepository _repository;
		public IActionResult Index()
		{
			return View();
		}
		public AccountController(GenericRepository repository, IMapper mapper) : base(mapper)
		{
			_repository = repository;
		}
		public IActionResult Login() => User.Identity.IsAuthenticated ? HomePage() : View();

		[HttpPost]
		public async Task<IActionResult> Login(LoginVM model)
		{
			var user = await _repository.GetOneAsync<AppUser, UserDataForApp>
							(
								where: x => x.Username == model.Username.ToLower(),
								AutoMapperProfile.LoginConf
							);
			if (user == null)
			{
				TempData["Mesg"] = "Tài khoản không tồn tại";
				return RedirectToAction(nameof(Login));
			}

			if (user.BlockedTo.HasValue && user.BlockedTo.Value >= DateTime.Now)
			{
				TempData["Mesg"] = $"Tài khoản của bạn bị khóa đến {user.BlockedTo.Value:dd/MM/yyyy HH:mm}";
				return RedirectToAction(nameof(Login));
			}

			var pwdHash = this.HashHMACSHA512WithKey(model.Password, user.PasswordSalt);
			if (!pwdHash.SequenceEqual(user.PasswordHash))
			{
				TempData["Mesg"] = "Tên đăng nhập hoặc mật khẩu không chính xác";
				return RedirectToAction(nameof(Login));
			}

			var claims = new List<Claim> {
							new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
							new Claim(ClaimTypes.Name, user.Username),
							new Claim(ClaimTypes.Email, user.Email),
							new Claim(AppClaimTypes.FullName, user.FullName),
							new Claim(AppClaimTypes.PhoneNumber, user.PhoneNumber1),
							new Claim(AppClaimTypes.RoleName, user.RoleName),
							new Claim(AppClaimTypes.Permissions, user.Permission),
						};
			var claimsIdentity = new ClaimsIdentity(claims, AppConst.COOKIES_AUTH);
			var principal = new ClaimsPrincipal(claimsIdentity);
			var authenPropeties = new AuthenticationProperties()
			{
				ExpiresUtc = DateTime.UtcNow.AddHours(AppConst.LOGIN_TIMEOUT),
				IsPersistent = model.RememberMe
			};
			await HttpContext.SignInAsync(AppConst.COOKIES_AUTH, principal, authenPropeties);

			//CreateDirIfNotExist(model.Username);
			var returnUrl = Request.Query["ReturnUrl"].ToString();
			if (returnUrl.IsNullOrEmpty())
			{
				return HomePage();
			}
			return Redirect(returnUrl);
		}
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(AppConst.COOKIES_AUTH);
			return RedirectToAction(nameof(Login));
		}

		public IActionResult AccessDenied() => View();


		// Tạo thư mục lưu file cho user khi đăng nhập (nếu chưa có)
		//private static void CreateDirIfNotExist(string username)
		//{
		//	var userPath = $"{AppConst.SYSTEM_FILE_PATH}/{username}";
		//	var fullPath = PathHelper.MapPath(userPath);
		//	if (!Directory.Exists(fullPath))
		//	{
		//		Directory.CreateDirectory(fullPath);
		//		// Thêm file tạm để giữ folder
		//		var file = PathHelper.MapPath($"{userPath}/{username}.txt");
		//		System.IO.File.WriteAllText(file, $"Hello {username}!");
		//	}
		//}
	}
}
