using MediatR;

namespace TMS.Application.ProjectParticipant.Commands.DeleteProjectParticipant
{
    public class DeleteProjectParticipantCommand : IRequest
    {
        public string UserId { get; set; }
        public int Id { get; set; }
    }
}