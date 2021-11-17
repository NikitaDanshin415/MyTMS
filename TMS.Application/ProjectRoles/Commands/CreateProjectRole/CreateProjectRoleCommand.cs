using System;
using MediatR;

namespace TMS.Application.ProjectRoles.Commands.CreateProjectRole
{
    /***
     * Информация о том, что необходимо для создания Роли проекта.
     */
    public class CreateProjectRoleCommand : IRequest<Guid>
    {
        public string RoleName { get; set; }
    }
}