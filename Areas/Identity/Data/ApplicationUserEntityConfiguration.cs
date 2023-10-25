using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Registration.Areas.Identity.Data
{
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<SampleUser>
    {
        public void Configure(EntityTypeBuilder<SampleUser> builder)
        {
            builder.Property(x => x.FirstName).HasMaxLength(100);
            builder.Property(x => x.LastName).HasMaxLength(100);
        }
    }
}