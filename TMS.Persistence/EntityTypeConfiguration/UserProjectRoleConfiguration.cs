using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class UserProjectRoleConfiguration : IEntityTypeConfiguration<UserProjectRole>
    {
        public void Configure(EntityTypeBuilder<UserProjectRole> builder)
        {
            builder.HasAlternateKey(e => new { e.ProjectId, e.UserId });
        }
    }
}