using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTeam.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data.DataSeeders
{
    public static class AppUserSeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppUser> builder)
        {
            var now = new DateTime(year: 2021, month: 11, day: 10);

            // Tạo mật khẩu
            var defaultPassword = "1111";
            HMACSHA512 hmac = new();
            var pwByte = Encoding.UTF8.GetBytes(defaultPassword);
            var pwdHash = hmac.ComputeHash(pwByte);
            var pwdSalt = hmac.Key;
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    Username = "admin",
                    PasswordHash = pwdHash,
                    PasswordSalt = pwdSalt,
                    Address = "Thành phố Hồ Chí Minh",
                    Email = "admin_test@gmail.com",
                    FullName = "Nguyen ProVip123",
                    PhoneNumber1 = "0939002144",
                    PhoneNumber2 = "0939002144",
                    CreatedBy = -1,
                    UpdatedBy = -1,
                    UpdatedDate = now,
                    CreatedDate = now,
                    AppRoleId = -1,              // Vai trò được tạo ở AppRoleSeeder
                }
            );
        }
    }
}
