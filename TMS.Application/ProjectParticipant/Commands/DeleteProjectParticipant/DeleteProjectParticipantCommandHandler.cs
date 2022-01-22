using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Common.Exceptions;
using TMS.Application.Interfaces;

namespace TMS.Application.ProjectParticipant.Commands.DeleteProjectParticipant
{
    public class DeleteProjectParticipantCommandHandler : IRequestHandler<DeleteProjectParticipantCommand>
    {

        private readonly ITmsDbContext _dbContext;

        public DeleteProjectParticipantCommandHandler(ITmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteProjectParticipantCommand request, CancellationToken cancellationToken)
        {

            var entity = await _dbContext.ProjectParticipants.FindAsync(new object[] {request.Id}, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(entity), request.Id);
            }

            _dbContext.ProjectParticipants.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}