namespace TMS.Domain
{
    public class TestPlanCases
    {
        public int Id { get; set; }
        public TestPlan TestPlan { get; set; }
        public TestCase TestCase { get; set; }
    }
}