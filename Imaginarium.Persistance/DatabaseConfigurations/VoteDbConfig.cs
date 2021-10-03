using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Imaginarium.Persistance.DatabaseConfigurations
{
    internal class VoteDbConfig : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasIndex(vote => new { vote.GamerId, vote.VotingId });

            builder.HasOne(vote => vote.Choice)
                .WithMany();
            
            builder.HasOne(vote => vote.Gamer)
                .WithMany();
            
            builder.HasOne(vote => vote.Voting)
                .WithMany(voting => voting.Votes)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
