using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TMS.Domain
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime AdditionDate { get; set; }
        public int ProjectStatusId { get; set; }
        public ProjectStatus ProjectStatus { get; set; }
    }
}
