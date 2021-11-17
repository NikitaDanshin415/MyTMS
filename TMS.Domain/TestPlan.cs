using System;

namespace TMS.Domain
{
    public class TestPlan
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AdditionDate { get; set; }

        public TestPlanStatus Status { get; set; }
        public UserProjectRole Author { get; set; }
    }
}