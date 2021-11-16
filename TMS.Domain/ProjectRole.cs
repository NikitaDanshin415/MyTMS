using System.Collections.Generic;

namespace EntityFrameworkTest.Models
{
    public class ProjectRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }


        public List<UserProjectRole> ProjectRoles { get; set; } = new List<UserProjectRole>();
       
    }
}