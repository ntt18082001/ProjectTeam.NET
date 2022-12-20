using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectTeam.Data.Entities;
using ProjectTeam.Share.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTeam.Data.Configurations
{
	public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.ToTable(DB.AppRole.TABLE_NAME);

			// Khóa chính
			builder.HasKey(m => m.Id);

			builder.Property(m => m.Name)
				.HasMaxLength(DB.AppRole.NAME_LENGTH)
				.IsRequired();

			builder.Property(m => m.Desc)
				.HasMaxLength(DB.AppRole.DESC_LENGTH)
				.IsRequired();
		}
	}
}
