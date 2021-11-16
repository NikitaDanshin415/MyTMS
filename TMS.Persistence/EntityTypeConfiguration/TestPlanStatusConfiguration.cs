using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestPlanStatusConfiguration : IEntityTypeConfiguration<TestPlanStatus>
    {
        public void Configure(EntityTypeBuilder<TestPlanStatus> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}