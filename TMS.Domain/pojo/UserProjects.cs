using System;

namespace TMS.Domain.pojo
{
    public class UserProjects
    {
        public Guid Id { get; set; }
        public string ProjectName { get; set; }
        public int ProjectStatusId { get; set; }
        public string UserId { get; set; }
    }
}