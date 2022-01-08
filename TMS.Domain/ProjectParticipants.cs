using System;

namespace TMS.Domain
{
    public class ProjectParticipants
    {
        public int Id { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }

        public ProjectRole ProjectRole { get; set; }
        public int ProjectRoleId { get; set; }
    }
}