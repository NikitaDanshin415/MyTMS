using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Interfaces;

namespace TMS.Application.TestCase.Commands.DeleteTestCase
{
    public class DeleteTestCaseCommandHandler : IRequestHandler<DeleteTestCaseCommand>
    {
        private readonly ITmsDbContext _dbContext;

        public DeleteTestCaseCommandHandler(ITmsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteTestCaseCommand request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.TestCases.FindAsync(new object[] {request.TestCaseId}, cancellationToken);

            _dbContext.TestCases.Remove(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}