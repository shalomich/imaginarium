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
    internal class RoundDbConfig : IEntityTypeConfiguration<Round>
    {
        public void Configure(EntityTypeBuilder<Round> builder)
        {
            builder.Property(round => round.Number).IsRequired();

            builder.HasIndex(round => new { round.Number, round.GameId }).IsUnique();

            builder.HasOne(round => round.Game)
                .WithMany(game => game.Rounds)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
