using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleLogin.Domain;

namespace SimpleLogin.Database.Configuration
{
    public class SampleConfiguration : IEntityTypeConfiguration<Sample>
    {
        public void Configure(EntityTypeBuilder<Sample> builder)
        {
            builder.ToTable("Sample", "dbo");

            builder.HasKey(x => x.Id);
        }
    }
}
