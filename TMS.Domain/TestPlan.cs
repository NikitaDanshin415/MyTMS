using System;

namespace TMS.Domain
{
    public class TestPlan
    {
        public int Id { get; set; }
        public string TestPlanName { get; set; }
        public string Description { get; set; }
        
        public DateTime AdditionDateTime { get; set; }
        
        public int StatusId { get; set; }
        public TestPlanStatus Satus { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
    }
}