using MediatR;

namespace TMS.Application.ProjectParticipant.Commands.CreateProjectParticipant
{
    public class CreateProjectParticipantCommand : IRequest<Domain.ProjectParticipants>, IRequest<int>
    {
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public int ProjectRoleId { get; set; }
    }
}