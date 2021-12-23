using System;
using MediatR;

namespace TMS.Application.ProjectParticipant.Queries.GetProjectParticipantsList
{
    public class GetProjectParticipantListQuery : IRequest<ProjectParticipantListVm>
    {
        public string UserId { get; set; }
    }
}