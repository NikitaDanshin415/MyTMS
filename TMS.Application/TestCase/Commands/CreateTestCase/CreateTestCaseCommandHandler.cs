using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Interfaces;

namespace TMS.Application.TestCase.Commands.CreateTestCase
{
    public class CreateTestCaseCommandHandler : IRequestHandler<CreateTestCaseCommand, Domain.TestCase>
    {
        private readonly ITmsDbContext _DbContext;

        public CreateTestCaseCommandHandler(ITmsDbContext context)
        {
            _DbContext = context;
        }

        public async Task<Domain.TestCase> Handle(CreateTestCaseCommand request, CancellationToken cancellationToken)
        {
            var testCase = new Domain.TestCase
            {
                Date = DateTime.Now,
                Description = request.Description,
                Name = request.Name,
                ProjectId = request.ProjectId,
                UserId = request.UserId,
                Steps = request.Steps
            };


            await _DbContext.TestCases
                .AddAsync(testCase,cancellationToken);
            await _DbContext.SaveChangesAsync(cancellationToken);

            return testCase;
        }
    }
}