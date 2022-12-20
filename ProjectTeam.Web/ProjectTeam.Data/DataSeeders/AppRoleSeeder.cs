using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTeam.Data.Entities;
using ProjectTeam.Share.Const;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data.DataSeeders
{
	public static class AppRoleSeeder
	{
		public static void SeedData(this EntityTypeBuilder<AppRole> builder)
		{
			var now = new DateTime(year: 2021, month: 12, day: 10);

			// Tạo vai trò
			var roleCustomer = new AppRole
			{
				Id = AppConst.RoleId.ROLE_CUSTOMER_ID,
				Name = "Khách hàng",
				Desc = "Khách hàng",
				CreatedDate = now,
				UpdatedDate = now,
				CanDelete = false
			};

			var roleAdmin = new AppRole
			{
				Id = AppConst.RoleId.ROLE_ADMIN_ID,
				Name = "Quản trị hệ thống",
				Desc = "Quản trị toàn bộ hệ thống",
				CreatedDate = now,
				UpdatedDate = now,
				CanDelete = true
			};

			builder.HasData(roleCustomer, roleAdmin);
		}
	}
}
