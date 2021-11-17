namespace TMS.Domain
{
    public class TestCaseStep
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string ExpectedReaction { get; set; }
        public TestCase TestCase { get; set; }
    }
}