using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace TMS.Domain
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<ProjectParticipants> UserProjectRoles { get; set; } = new List<ProjectParticipants>();

    }
}