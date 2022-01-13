using AutoMapper;
using TMS.Application.Common.Mapping;

namespace TMS.Application.Users.Queries.GetUsersList
{
    public class UserListDto : IMapWith<Domain.User>
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.User, UserListDto>()
                .ForMember(userListDto => userListDto.Id,
                    opt => opt.MapFrom(userList => userList.Id))
                .ForMember(userListDto => userListDto.UserName,
                    opt => opt.MapFrom(userList => userList.UserName));
        }

    }
}