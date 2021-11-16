using System;

namespace EntityFrameworkTest.Models
{
    public class TestCaseResult
    {
        public int Id { get; set; }
        public DateTime AdditionDate { get; set; }
        public string Comments { get; set; }
        public string Description { get; set; }

        public UserProjectRole Author { get; set; }
        public Result Result { get; set; }


    }
}