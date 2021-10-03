using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Imaginarium.Persistance.DatabaseConfigurations
{
    internal class GamerDbConfig : IEntityTypeConfiguration<Gamer>
    {
        public void Configure(EntityTypeBuilder<Gamer> builder)
        {
            builder.HasOne(gamer => gamer.User)
                .WithOne(user => user.Gamer)
                .HasForeignKey<Gamer>(gamer => gamer.UserName)
                .HasPrincipalKey<User>(user => user.Name)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(gamer => gamer.Game)
                .WithMany(game => game.Gamers)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
