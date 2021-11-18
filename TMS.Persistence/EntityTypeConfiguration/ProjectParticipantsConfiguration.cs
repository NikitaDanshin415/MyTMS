using TMS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class ProjectParticipantsConfiguration : IEntityTypeConfiguration<ProjectParticipants>
    {
        public void Configure(EntityTypeBuilder<ProjectParticipants> builder)
        {
            builder.HasAlternateKey(e => new { e.ProjectId, e.UserId });
        }
    }
}