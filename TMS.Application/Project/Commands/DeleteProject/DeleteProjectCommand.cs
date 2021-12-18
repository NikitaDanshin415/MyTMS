using System;
using MediatR;

namespace TMS.Application.Project.Commands.DeleteProject
{
    public class DeleteProjectCommand : IRequest
    {
        public string UserId { get; set; }
        public Guid Id { get; set; }
    }
}