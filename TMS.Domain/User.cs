using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Surname { get; set; }
        public string Secname { get; set; }
        public string Firname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<UserProjectRole> UserProjectRoles { get; set; } = new List<UserProjectRole>();

    }
}