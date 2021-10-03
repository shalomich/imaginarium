using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.DatabaseConfigurations
{
    internal class CardDbConfig : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.Property(card => card.Name).IsRequired();

            builder.HasIndex(card => new { card.Name, card.CollectionId }).IsUnique();

            builder.HasOne(card => card.Collection)
                .WithMany(collection => collection.Cards);
        }
    }
}
