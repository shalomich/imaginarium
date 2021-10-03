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
    internal class DeckDbConfig : IEntityTypeConfiguration<Deck>
    {
        public void Configure(EntityTypeBuilder<Deck> builder)
        {
            builder.HasMany(deck => deck.Cards)
                .WithMany(card => card.Decks);

            builder.HasOne(deck => deck.Game)
                .WithOne(game => game.Deck)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
