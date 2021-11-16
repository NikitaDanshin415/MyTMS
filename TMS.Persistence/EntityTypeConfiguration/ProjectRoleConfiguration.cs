using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class ProjectRoleConfiguration : IEntityTypeConfiguration<ProjectRole>
    {
        public void Configure(EntityTypeBuilder<ProjectRole> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasData(new ProjectRole { Id = 1, RoleName = "Admin"});
            builder.HasData(new ProjectRole { Id = 2, RoleName = "User" });
        }
    }
}