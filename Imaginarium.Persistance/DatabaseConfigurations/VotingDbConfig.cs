
using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Imaginarium.Persistance.DatabaseConfigurations
{
    internal class VotingDbConfig : IEntityTypeConfiguration<Voting>
    {
        public void Configure(EntityTypeBuilder<Voting> builder)
        {
            builder.HasOne(voting => voting.Round)
                .WithOne(round => round.Voting)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
