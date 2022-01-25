using MediatR;

namespace TMS.Application.TestCase.Queries.GetTestCaseDetails
{
    public class GetTestCaseDetailsQuery : IRequest<TestCaseDetailsVm>
    {
        public string UserId { get; set; }
        public int TestCaseId { get; set; }
    }
}