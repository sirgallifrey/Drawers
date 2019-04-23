using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Drawers.Domain.Entities;

namespace Drawers.Persistence.Configurations
{
    public class PersonPhoneNumberConfiguration : IEntityTypeConfiguration<PersonPhoneNumber>
    {
        public void Configure(EntityTypeBuilder<PersonPhoneNumber> builder)
        {
            builder.HasOne(e => e.Person);
            builder.HasOne(e => e.PhoneNumber);
            //builder.HasIndex(e => new {e.Person, e.PhoneNumber}).IsUnique(true);
        }
    }
}
