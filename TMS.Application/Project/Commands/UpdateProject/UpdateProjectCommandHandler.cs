using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;

namespace TMS.Application.Project.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand>
    {
        private ITmsDbContext _dbContext;

        public UpdateProjectCommandHandler(ITmsDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Unit> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            //Ищем в бд проект
            var entity =
                await _dbContext.Projects.FirstOrDefaultAsync(project => project.Id == request.ProjectId, cancellationToken);

            //если проект не найден или автор проекта и пользовательне совпадают, возвращаем исключение
            if (entity == null)
            {
                throw new NotFoundException(nameof(Project), request.ProjectId);
            }

            if (entity.ProjectName != request.ProjectName)
            {
                entity.ProjectName = request.ProjectName;
            }

            if (entity.ProjectStatusId != request.ProjectStatusId 
                && request.ProjectStatusId != 0)
            {
                entity.ProjectStatusId = request.ProjectStatusId;
            }
            

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;

        }
    }
}