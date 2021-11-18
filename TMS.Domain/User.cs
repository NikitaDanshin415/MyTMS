using System;
using System.Collections.Generic;

namespace TMS.Domain
{
    public class User
    {
        public Guid Id { get; set; }

        public string Surname { get; set; }
        public string Secname { get; set; }
        public string Firname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        public List<ProjectParticipants> UserProjectRoles { get; set; } = new List<ProjectParticipants>();

    }
}