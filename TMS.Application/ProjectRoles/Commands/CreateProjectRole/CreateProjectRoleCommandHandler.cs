using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Interfaces;
using TMS.Domain;

namespace TMS.Application.ProjectRoles.Commands.CreateProjectRole
{
    public class CreateProjectRoleCommandHandler : IRequestHandler<CreateProjectRoleCommand, Guid>
    {
        private readonly ITmsDbContext _DbContext;

        public CreateProjectRoleCommandHandler(ITmsDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        /***
         * Формируем роль из запроса и возвращаем id созданного проекта.
         */

        public async Task<Guid> Handle(CreateProjectRoleCommand request, CancellationToken cancellationToken)
        {
            var projectRole = new ProjectRole
            {
                Id = new Guid(),
                RoleName = request.RoleName
            };

            await _DbContext.ProjectRoles.AddAsync(projectRole, cancellationToken);
            await _DbContext.SaveChangesAsync(cancellationToken);

            return projectRole.Id;
        }
    }
}