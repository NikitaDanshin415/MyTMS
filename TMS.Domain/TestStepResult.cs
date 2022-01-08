namespace TMS.Domain
{
    public class TestStepResult
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Reaction { get; set; }
        public string FactReaction { get; set; }
        
        public int TestCaseResultId { get; set; }
        public TestCaseResult TestCaseResult { get; set; }
    }
}