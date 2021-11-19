using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TMS.Application.Interfaces;
using TMS.Domain;
using TMS.Persistence.EntityTypeConfiguration;

namespace TMS.Persistence
{
    public class TmsDbContext : IdentityDbContext<User>, ITmsDbContext
    {
        public DbSet<User> Users { get; set; } 
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectStatus> ProjectStatus { get; set; }
        public DbSet<ProjectRole> ProjectRoles { get; set; }
        public DbSet<ProjectParticipants> ProjectParticipants { get; set; }



        public TmsDbContext(DbContextOptions<TmsDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectStatusConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectParticipantsConfiguration());

            modelBuilder.Entity<User>(entity => entity.ToTable(name: "Users"));
            modelBuilder.Entity<IdentityRole>(entity => entity.ToTable(name: "Roles"));
            modelBuilder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UserRoles"));
            modelBuilder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UserClaim"));
            modelBuilder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UserLogins"));
            modelBuilder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UserTokens"));
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RoleClaims"));

            base.OnModelCreating(modelBuilder);
        }
    }
}