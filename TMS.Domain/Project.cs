using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime AdditionDate { get; set; }
        public int ProjectStatusId { get; set; }
        public ProjectStatus ProjectStatus { get; set; }

        public List<UserProjectRole> UserProjectRoles { get; set; } = new List<UserProjectRole>();
    }
}
