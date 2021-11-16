using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class TestCaseConfiguration : IEntityTypeConfiguration<TestCase>
    {
        public void Configure(EntityTypeBuilder<TestCase> builder)
        {
            builder.HasKey(e => e.Id);

        }
    }
}