using System;
using MediatR;

namespace TMS.Application.ProjectRole.Queries.GetProjectRoleDetails
{
    public class GetProjectRoleQuery : IRequest<ProjectRoleDetailsVm>
    {
        public Guid Id { get; set; }
    }
}