using AutoMapper;
using ProjectTeam.Data.Entities;
using ProjectTeam.Web.ViewModels.Account;

namespace ProjectTeam.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{

		// Cấu hình mapping cho AccountController, action Login
		public static MapperConfiguration LoginConf = new(mapper =>
		{
			// Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
			mapper.CreateMap<AppUser, UserDataForApp>()
				.ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole == null ? "" : uEntity.AppRole.Name))
				.ForMember(uItem => uItem.Permission, opts => opts.MapFrom
				(
					uEntity => string.Join(',', uEntity.AppRole
														.AppRolePermissions
														.Select(p => p.MstPermissionId))
				)
			);
		});

	}
}
