using System;
using System.Collections.Generic;

namespace EntityFrameworkTest.Models
{
    public class UserProjectRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime AdditionToProject { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int ProjectRoleId { get; set; }
        public ProjectRole ProjectRoles { get; set; }  // компания пользователя
    }
}