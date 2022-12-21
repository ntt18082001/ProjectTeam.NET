using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProjectTeam.Data.Entities;
using ProjectTeam.Data.Serivces;
using ProjectTeam.Web.ViewModels.AppUser;

namespace ProjectTeam.Web.Controllers
{
    public class AppUserController : BaseAdminController
    {
        private GenericRepository _repository;
		public AppUserController(IMapper mapper , GenericRepository repository) : base(mapper) 
        {
            _repository = repository;
        }

		public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserAddOrEditVM model)
        {
            if (!ModelState.IsValid)
            {
                SetErrorMesg(MODEL_STATE_INVALID_MESG, true);
                return View(model);
            }
            if (await _repository.AnyAsync<AppUser>(u => u.Username.Equals(model.Username)))
            {
                SetErrorMesg("Tên đăng nhập này đã tồn tại!");
                return View(model);
            }
            try
            {
                var hashResult = HashHMACSHA512(model.Password);
                model.PasswordHash = hashResult.Value;
                model.PasswordSalt = hashResult.Key;
                var user = _mapper.Map<AppUser>(model);
                await _repository.AddAsync(user);
                SetSuccessMesg($"Thêm tài khoản [{user.Username}] thành công!");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
              
                return View(model);
            }
        }
    }
}
