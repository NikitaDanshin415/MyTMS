using System;
using MediatR;

namespace TMS.Application.Project.Queries.GetProjectList
{
    public class GetProjectListQuery : IRequest<ProjectListVm>
    {
        public Guid UserId { get; set; }
    }
}