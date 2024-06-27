using FormApplicationApiDotNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FormApplicationApiDotNet.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Email).IsRequired();

            //The Fluent API provides a larger range of configuration options than Data Annotation attributes. Fluent API configuration also facilitates cleaner code,
            //in that the configuration can be kept separate from the domain classes.
            // For example Rather than using
            //builder.Property(b => b.Id).IsRequired();
            //builder.Property(b => b.Id).GetType(varchar(50));
            // we can use
            //builder.Property(b => b.Id).IsRequired().GetType(varchar(50));
        }
    }
}
