using System;
using MediatR;

namespace TMS.Application.Project.Queries.GetProjectDetails
{
    public class GetProjectDetailsQuery : IRequest<ProjectDetailsVm>
    {
        public string UserId { get; set; }
        public int ProjectId { get; set; }
    }
}