using System;
using MediatR;

namespace TMS.Application.ProjectRole.Queries.GetProjectRoleDetails
{
    public class GetProjectRoleDetailsQuery : IRequest<ProjectRoleDetailsVm>
    {
        public Guid Id { get; set; }
    }
}