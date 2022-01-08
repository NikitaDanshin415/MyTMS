using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using TMS.Application.Interfaces;

namespace TMS.Application.TestPlan.Commands.CreateTestPlan
{
    public class CreateTestPlanCommandHandler : IRequestHandler<CreateTestPlanCommand, Domain.TestPlan>
    {
        private readonly ITmsDbContext _DbContext;

        public CreateTestPlanCommandHandler(ITmsDbContext context)
        {
            _DbContext = context;
        }

        public async Task<Domain.TestPlan> Handle(CreateTestPlanCommand request, CancellationToken cancellationToken)
        {

            //var testPlan = new Domain.TestPlan
            //{
            //    TestPlanName = request.TestPlanName,
            //    Description = request.Description,
            //    AdditionDateTime = DateTime.Now,
            //};

            //await _DbContext.TestPlans.AddAsync(testPlan, cancellationToken);
            //await _DbContext.SaveChangesAsync(cancellationToken);

            //return testPlan;
            throw new System.NotImplementedException();
        }
    }
}