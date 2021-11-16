using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class ProjectStatusConfiguration : IEntityTypeConfiguration<ProjectStatus>
    {
        public void Configure(EntityTypeBuilder<ProjectStatus> builder)
        {
            builder.HasKey(projectStatus => projectStatus.Id);
            builder.HasData(new ProjectStatus {Id = 1, StatusName = "Открыт"});
            builder.HasData(new ProjectStatus { Id = 2, StatusName = "Закрыт" });
        }
    }
}