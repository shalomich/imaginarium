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
    internal class HandDbConfig : IEntityTypeConfiguration<Hand>
    {
        public void Configure(EntityTypeBuilder<Hand> builder)
        {
            builder.HasMany(hand => hand.Cards)
                .WithMany(card => card.Hands);

            builder.HasOne(hand => hand.Gamer)
                .WithOne(gamer => gamer.Hand)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
