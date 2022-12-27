using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjectTeam.Web.ViewModels.Account
{
    public class LoginVM
    {
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }


        [DisplayName("Ghi nhớ mật khẩu")]
        public bool RememberMe { get; set; }
    }
}
