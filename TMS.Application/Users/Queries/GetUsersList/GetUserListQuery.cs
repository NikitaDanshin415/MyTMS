using MediatR;

namespace TMS.Application.Users.Queries.GetUsersList
{
    public class GetUserListQuery : IRequest<UserListVm>
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}