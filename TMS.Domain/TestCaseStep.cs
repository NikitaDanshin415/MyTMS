namespace TMS.Domain
{
    public class TestCaseStep
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string Reaction { get; set; }

        public int TestCaseId { get; set; }
    }
}