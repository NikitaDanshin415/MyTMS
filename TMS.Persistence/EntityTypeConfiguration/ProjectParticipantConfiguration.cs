using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMS.Domain;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class ProjectParticipantConfiguration : IEntityTypeConfiguration<ProjectParticipants>
    {
        public void Configure(EntityTypeBuilder<ProjectParticipants> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasAlternateKey(e => new { e.ProjectId, e.UserId });
        }
    }
}