using System;
using MediatR;

namespace TMS.Application.TestPlan.Queries.GetTestPlanList
{
    public class GetTestPlanListQuery : IRequest<TestPlanListVm>
    {
        public string UserId { get; set; }
        public Guid ProjectId { get; set; }
    }
}