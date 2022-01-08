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
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Domain.Project>
    {
        private readonly ITmsDbContext _DbContext;

        public CreateProjectCommandHandler(ITmsDbContext context)
        {
            _DbContext = context;
        }

        /***
         * Формируем проект из запроса и возвращаем id созданного проекта.
         */
        public async Task<Domain.Project> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            //var project = new Domain.Project
            //{
            //    ProjectName = request.ProjectName,
            //    AdditionDate = DateTime.Now,
            //    ProjectStatusId = 1
            //};

            ////Ищем роль создателя проекта
            //var role = await _DbContext.ProjectRoles.FirstOrDefaultAsync(projectRole =>
            //    projectRole.Id == 1, cancellationToken);

            ////если Роль
            ////не найдена, возвращаем ошибку
            //if (role == null)
            //{
            //    throw new NotFoundException(nameof(Project), request.UserId);
            //}

            //var userProjectRole = new ProjectParticipants
            //{
            //    UserId = request.UserId.ToString(),
            //    ProjectRoleId = role.Id, 
            //    AdditionToProject = DateTime.Now,
            //};

            //await _DbContext.Projects.AddAsync(project, cancellationToken);
            //await _DbContext.ProjectParticipants.AddAsync(userProjectRole, cancellationToken);
            //await _DbContext.SaveChangesAsync(cancellationToken);

            //return project;
            throw new System.NotImplementedException();
        }
    }
}