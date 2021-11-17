using System;
using MediatR;

namespace TMS.Application.Project.Commands.CreateProject
{
    /***
     * Информация о том, что необходимо для создания проекта.
     */
    public class CreateProjectCommand : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public string ProjectName { get; set; }
    }
}