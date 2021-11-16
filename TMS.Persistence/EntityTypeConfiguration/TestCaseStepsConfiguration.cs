using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestCaseStepsConfiguration : IEntityTypeConfiguration<TestCaseStep>
    {
        public void Configure(EntityTypeBuilder<TestCaseStep> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}