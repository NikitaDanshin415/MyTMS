using System;
using MediatR;

namespace TMS.Application.TestPlan.Commands.CreateTestPlan
{
    public class CreateTestPlanCommand : IRequest<Domain.TestPlan>, IRequest<int>
    {
        public string TestPlanName { get; set; }
        public string Description { get; set; }
        public Guid ProjectParticipantId { get; set; }
    }
}