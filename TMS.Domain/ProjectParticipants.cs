using System;

namespace TMS.Domain
{
    public class ProjectParticipants
    {
  public DateTime AdditionToProject { get; set; }

        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public Guid ProjectRoleId { get; set; }
        public ProjectRole ProjectRoles { get; set; }
    }
}