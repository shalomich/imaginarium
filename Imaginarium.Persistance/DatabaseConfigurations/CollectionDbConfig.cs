using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Imaginarium.Persistance.DatabaseConfigurations
{
    internal class CollectionDbConfig : IEntityTypeConfiguration<Collection>
    {
        public void Configure(EntityTypeBuilder<Collection> builder)
        {
            builder.Property(collection => collection.Name).IsRequired();

            builder.HasIndex(collection => new { collection.Name, collection.UserId });

            builder.HasOne(colection => colection.User)
                .WithMany(user => user.Collections)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
