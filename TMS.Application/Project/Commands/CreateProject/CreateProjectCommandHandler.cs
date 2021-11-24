using System;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;
using TMS.Domain;

namespace TMS.Application.Project.Commands.CreateProject
{
    /***
     * Логика создания проекта, на освное информации из запроса.
     */
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
    {
        private readonly ITmsDbContext _DbContext;

        public CreateProjectCommandHandler(ITmsDbContext context)
        {
            _DbContext = context;
        }

        /***
         * Формируем проект из запроса и возвращаем id созданного проекта.
         */
        public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var project = new Domain.Project
            {
                ProjectName = request.ProjectName,
                Id = Guid.NewGuid(),
                AdditionDate = DateTime.Now,
                ProjectStatusId = 1
            };
            
            //Ищем роль создателя проекта
            var role = await _DbContext.ProjectRoles.FirstOrDefaultAsync(projectRole =>
                projectRole.RoleName == "Admin", cancellationToken);

            //если Роль админ не найдена, возвращаем ошибку
            if (role == null)
            {
                throw new NotFoundException(nameof(Project), request.UserId);
            }

            var userProjectRole = new ProjectParticipants
            {
                UserId = request.UserId.ToString(), 
                ProjectId = project.Id,
                ProjectRoleId = role.Id, 
                AdditionToProject = DateTime.Now,
            };

            await _DbContext.Projects.AddAsync(project, cancellationToken);
            await _DbContext.ProjectParticipants.AddAsync(userProjectRole, cancellationToken);
            await _DbContext.SaveChangesAsync(cancellationToken);
            
            return project.Id;
        }
    }
}