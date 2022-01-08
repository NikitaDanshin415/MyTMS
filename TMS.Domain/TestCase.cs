using System;

namespace TMS.Domain
{
    public class TestCase
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public User User { get; set; }
        public string UserId { get; set; }
        
    }
}