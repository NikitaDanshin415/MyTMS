using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TMS.Domain;

namespace TMS.Application.Interfaces
{
    public interface ITmsDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Domain.Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<UserProjectRole> UserProjectRoles { get; set; }


        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
