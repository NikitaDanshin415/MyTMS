using System;
using MediatR;

namespace TMS.Application.Project.Commands.UpdateProject
{
    public class UpdateProjectCommand : IRequest
    {
        public int ProjectId { get; set; }
        public string UserId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatusId { get; set; }
    }
}