using TMS.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestCaseResultConfiguration : IEntityTypeConfiguration<TestCaseResult>
    {
        public void Configure(EntityTypeBuilder<TestCaseResult> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}