namespace EntityFrameworkTest.Models
{
    public class PlanTestcaseResult
    {
        public int Id { get; set; }

        public TestPlan TestPlan { get; set; }
        public TestCase TestCase { get; set; }
        public TestCaseResult TestCaseResult { get; set; }
    }
}