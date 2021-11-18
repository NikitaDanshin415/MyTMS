using System;
using System.Collections.Generic;

namespace TMS.Domain
{
    public class ProjectRole
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        public List<ProjectParticipants> ProjectRoles { get; set; } = new List<ProjectParticipants>();
       
    }
}