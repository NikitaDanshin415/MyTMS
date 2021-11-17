using System;

namespace TMS.Domain
{
    public class TestCase
    {
        public int Id { get; set; }
        public DateTime AdditionDate { get; set; }
        public string Discription { get; set; }

        public UserProjectRole Author { get; set; }
    }
}