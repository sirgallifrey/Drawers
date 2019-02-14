using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Drawers.Domain.Entities;

namespace Drawers.Persistence.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(40);
            builder.HasOne(e => e.Company);
            
        }
    }
}
