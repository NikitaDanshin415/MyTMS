using System;
using MediatR;

namespace TMS.Application.ProjectRole.Queries.GetProjectRolesList
{
    public class GetProjectRoleListQuery : IRequest<ProjectRoleListVm>
    {
        public string UserId { get; set; }
    }
}