using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestCaseStepResultConfiguration : IEntityTypeConfiguration<TestCaseStepResult>
    {
        public void Configure(EntityTypeBuilder<TestCaseStepResult> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}