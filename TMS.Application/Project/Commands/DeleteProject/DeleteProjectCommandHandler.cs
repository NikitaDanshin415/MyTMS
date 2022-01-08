using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;

namespace TMS.Application.Project.Commands.DeleteProject
{
    public class DeleteProjectCommandHandler 
        : IRequestHandler<DeleteProjectCommand>
    {
        private readonly ITmsDbContext _dbContext;

        public DeleteProjectCommandHandler(ITmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public async Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        //{
        //    var entity = await _dbContext.Projects.FindAsync(new object[] {request.Id}, cancellationToken);

        //    if (entity == null)
        //    {
        //        throw new NotFoundException(nameof(entity), request.Id);
        //    }

        //    _dbContext.Projects.Remove(entity);
        //    await _dbContext.SaveChangesAsync(cancellationToken);

        //    return Unit.Value;
        //}
        public Task<Unit> Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}