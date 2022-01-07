using System;
using MediatR;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantDetails
{
    public class GetProjectParticipantDetailsQuery : IRequest<ProjectParticipantDetailsVm>
    {
        public string UserId { get; set; }
        public Guid Id { get; set; }
    }
}