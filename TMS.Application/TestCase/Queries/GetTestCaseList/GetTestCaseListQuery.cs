using MediatR;
using TMS.Application.TestPlan.Queries.GetTestPlanList;

namespace TMS.Application.TestCase.Queries.GetTestCaseList
{
    public class GetTestCaseListQuery : IRequest<TestCaseListVm>, IRequest<TestPlanListVm>
    {
        public string UserId { get; set; }
        public int ProjectId { get; set; }
    }
}