using MediatR;

namespace TMS.Application.TestCase.Commands.DeleteTestCase
{
    public class DeleteTestCaseCommand : IRequest
    {
        public string UserId { get; set; }
        public int TestCaseId { get; set; }
    }
}