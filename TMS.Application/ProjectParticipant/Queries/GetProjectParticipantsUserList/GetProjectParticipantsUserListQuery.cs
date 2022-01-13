using MediatR;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsUserList
{
    public class GetProjectParticipantsUserListQuery : IRequest<ProjectParticipantsUserListVm>
    {
        public string UserId { get; set; }
        public int ProjectId { get; set; }
    }
}