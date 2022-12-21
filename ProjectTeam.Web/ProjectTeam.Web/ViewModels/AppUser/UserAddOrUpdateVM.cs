using ProjectTeam.Share.Consts;
using System.ComponentModel.DataAnnotations;

namespace ProjectTeam.Web.ViewModels.AppUser
{
    public class UserAddOrEditVM
    {
        public int Id { get; set; }

        [Required]
        [RegularExpression(@"^(?!.*[_.]{2})[a-zA-Z0-9._]+$")]
        [MaxLength(50)]
        [MinLength(4)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [MaxLength(50)]
        [MinLength(4)]
        public string ConfirmPwd { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(@"^\+*\d{10,15}$")]
        public string PhoneNumber1 { get; set; }

        [RegularExpression(@"^\+*\d{10,15}$")]
        public string PhoneNumber2 { get; set; }

        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$")]
        public string Email { get; set; }
        public string Address { get; set; }
        public int? AppRoleId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
