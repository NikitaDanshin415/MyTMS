using System;
using MediatR;

namespace TMS.Application.Project.Commands.CreateProject
{
    /***
     * Информация о том, что необходимо для создания проекта.
     */
    public class CreateProjectCommand : IRequest<Domain.Project>, IRequest<int>
    {
        public string UserId { get; set; }
        public string ProjectName { get; set; }
    }
}