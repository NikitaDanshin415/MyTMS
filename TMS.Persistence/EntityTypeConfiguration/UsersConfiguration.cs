using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TMS.Application.Interfaces;

namespace TMS.Persistence.EntityTypeConfiguration
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasAlternateKey(e => e.Email);
        }
    }
}