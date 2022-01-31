using System.Collections.Generic;

namespace TMS.Domain
{
    public class TestPlanCases
    {
        public int Id { get; set; }
        public TestPlan TestPlan { get; set; }
        public TestCase TestCase { get; set; }
        public List<TestCaseResult> TestCaseResult { get; set; } = new List<TestCaseResult>();
    }
}