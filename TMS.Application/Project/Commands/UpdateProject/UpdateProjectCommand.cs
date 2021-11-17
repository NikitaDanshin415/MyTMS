using System;
using MediatR;

namespace TMS.Application.Project.Commands.UpdateProject
{
    public class UpdateProjectCommand : IRequest
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatusId { get; set; }
    }
}