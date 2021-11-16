using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class PlanTestcaseResultConfiguration : IEntityTypeConfiguration<PlanTestcaseResult>
    {
        public void Configure(EntityTypeBuilder<PlanTestcaseResult> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}