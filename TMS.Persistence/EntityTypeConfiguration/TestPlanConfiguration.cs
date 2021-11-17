using TMS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestPlanConfiguration : IEntityTypeConfiguration<TestPlan>
    {
        public void Configure(EntityTypeBuilder<TestPlan> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}