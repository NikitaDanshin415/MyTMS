using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMS.Domain;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class ProjectStatusConfiguration : IEntityTypeConfiguration<ProjectStatus>
    {
        public void Configure(EntityTypeBuilder<ProjectStatus> builder)
        {
            builder.HasKey(projectStatus => projectStatus.Id);
            builder.HasAlternateKey(e => e.StatusName);
            builder.HasData(new ProjectStatus { Id = 1, StatusName = "Open" });
            builder.HasData(new ProjectStatus { Id = 2, StatusName = "Close" });
        }
    }
}