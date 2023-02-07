using AutoMapper;
using log4net;
using Microsoft.AspNetCore.Mvc;
using ProjectTeam.Web.Common;
using System.Security.Cryptography;
using System.Text;

namespace ProjectTeam.Web.Controllers
{
    public class BaseAdminController : Controller
    {
		protected readonly IMapper _mapper;
        private readonly ILog _logger;
        public BaseAdminController(IMapper mapper)
		{
			_mapper = mapper;
            _logger = LogManager.GetLogger(typeof(BaseAdminController));
        }
		/// <summary>
		/// Gán thông báo lỗi để hiển thị lên view
		/// </summary>
		/// <param name="mesg">Thông báo lỗi</param>
		/// <param name="modelStateIsInvalid">Đặt là true khi lỗi validate dữ liệu</param>
		protected void SetErrorMesg(string mesg, bool modelStateIsInvalid = false)
		{
			TempData["Err"] = mesg;
			if (modelStateIsInvalid)
			{
				// hiển thị tin nhắn lỗi ở file log
				var invalidMesg = string.Join("\n", ModelState.Values
												.SelectMany(v => v.Errors)
												.Select(e => e.ErrorMessage));
				_logger.Error($"Model state is invalid: {invalidMesg}");
			}
		}
        protected void LogException(Exception ex)
        {
            _logger.Error(ex);
            SetErrorMesg("Error");
        }
        protected void SetSuccessMesg(string mesg) => TempData["Success"] = mesg;
		protected byte[] HashHMACSHA512WithKey(string pwd, byte[] key)
		{
			HMACSHA512 hmac = new(key);
			var pwdByte = Encoding.UTF8.GetBytes(pwd);
			return hmac.ComputeHash(pwdByte);
		}

		protected HashResult HashHMACSHA512(string pwd)
		{
			var hashResult = new HashResult();
			HMACSHA512 hmac = new();
			var pwdByte = Encoding.UTF8.GetBytes(pwd);
			hashResult.Value = hmac.ComputeHash(pwdByte);
			hashResult.Key = hmac.Key;
			return hashResult;
		}
	}
}
