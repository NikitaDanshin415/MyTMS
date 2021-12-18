using System;
using MediatR;

namespace TMS.Application.Project.Queries.GetProjectList
{
    public class GetProjectListQuery : IRequest<ProjectListVm>
    {
        public string UserId { get; set; }
    }
}