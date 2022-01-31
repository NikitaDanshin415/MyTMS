using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Domain;

namespace TMS.Application.TestCase.Commands.UpdateTestCase
{
    public class UpdateTestCaseCommandHandler : IRequestHandler<UpdateTestCaseCommand>
    {
        private ITmsDbContext _dbContext;

        public UpdateTestCaseCommandHandler(ITmsDbContext context)
        {
            _dbContext = context;
        }

        public async Task<Unit> Handle(UpdateTestCaseCommand request, CancellationToken cancellationToken)
        {
        
            var entity =
                await _dbContext
                    .TestCases
                    .Include(e=> e.Steps)
                    .FirstOrDefaultAsync(e => e.Id == request.Id, cancellationToken);

            if (request.Description != entity.Description)
            {
                entity.Description = request.Description;
            }

            if (request.Name != entity.Name)
            {
                entity.Name = request.Name;
            }

            entity.Steps = request.Steps;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}