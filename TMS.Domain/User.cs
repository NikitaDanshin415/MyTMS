using System;
using System.Collections.Generic;

namespace TMS.Domain
{
    public class User
    {
        public string Id { get; set; }

        public List<ProjectParticipants> UserProjectRoles { get; set; } = new List<ProjectParticipants>();

    }
}