using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TMS.Domain
{
    public class ProjectStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();

    }
}