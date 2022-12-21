using AutoMapper;
using ProjectTeam.Data.Entities;
using ProjectTeam.Web.ViewModels.AppUser;

namespace ProjectTeam.Web.WebConfig
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
            CreateMap<UserAddOrEditVM, AppUser>();
        }
        public static MapperConfiguration UserIndexConf = new(mapper =>
        {
            // Map dữ liệu từ AppUser sang UserListItemVM, map thuộc tính RoleName
            mapper.CreateMap<AppUser, UserListItemVM>()
                .ForMember(uItem => uItem.RoleName, opts => opts.MapFrom(uEntity => uEntity.AppRole.Name));
        });
    }
}
