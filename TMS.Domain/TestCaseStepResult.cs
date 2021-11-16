namespace EntityFrameworkTest.Models
{
    public class TestCaseStepResult
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string ExpectedReaction { get; set; }
        public string FactReaction { get; set; }
        public string Result { get; set; }
        public TestCaseResult TestCaseResult { get; set; }
    }
}