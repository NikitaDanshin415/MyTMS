using System;
using System.Collections.Generic;

namespace TMS.Domain
{
    public class ProjectRole
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        public List<UserProjectRole> ProjectRoles { get; set; } = new List<UserProjectRole>();
       
    }
}