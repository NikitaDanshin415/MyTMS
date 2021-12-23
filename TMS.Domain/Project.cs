using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TMS.Domain
{
    public class Project
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public DateTime AdditionDate { get; set; }
        public int ProjectStatusId { get; set; }

    }
}
