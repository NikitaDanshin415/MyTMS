using System;

namespace TMS.Domain
{
    public class TestCaseResult
    {
        public int Id { get; set; }
        public DateTime AdditionDateTime { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }


        public int TestPlanCasesId { get; set; }
        public TestPlanCases TestPlanCase { get; set; }

        public int TestCaseResultResultId { get; set; }
        public TestCaseResultResult TestCaseResultResult { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}