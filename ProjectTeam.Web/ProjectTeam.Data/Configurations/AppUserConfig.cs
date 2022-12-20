using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTeam.Data.Entities;
using ProjectTeam.Share.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data.Configurations
{
    public class AppUserConfig : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            builder.HasKey(x => x.Id);
            builder.Property(m => m.Username)
                .HasMaxLength(DB.AppUser.USERNAME_LENGTH)
                .IsRequired(true)
                .IsUnicode(false);
            // IsUnique để usernam là duy nhất ko được trùng lại
            builder.HasIndex(x => x.Username).IsUnique(true);
            builder.Property(m => m.Address)
                .HasMaxLength(DB.AppUser.ADDRESS_LENGTH);

            builder.Property(m => m.Avatar)
                .HasMaxLength(DB.AppUser.AVATAR_LENGTH)
                .IsRequired(false);

            builder.Property(m => m.Email)
                .HasMaxLength(DB.AppUser.EMAIL_LENGTH)
                .IsUnicode(false);
            // IsUnique để usernam là duy nhất ko được trùng lại
            builder.HasIndex(x => x.Email).IsUnique(true);

            builder.Property(m => m.FullName)
                .HasMaxLength(DB.AppUser.FULLNAME_LENGTH);

            builder.Property(m => m.PasswordHash)
                .HasMaxLength(DB.AppUser.PWD_LENGTH);

            builder.Property(m => m.PasswordSalt)
                .HasMaxLength(DB.AppUser.PWD_LENGTH);

            builder.Property(m => m.PhoneNumber1)
                .HasMaxLength(DB.AppUser.PHONE_LENGTH)
                .IsUnicode(false);

            builder.Property(m => m.PhoneNumber2)
                .HasMaxLength(DB.AppUser.PHONE_LENGTH)
                .IsUnicode(false);
        }
    }
}
