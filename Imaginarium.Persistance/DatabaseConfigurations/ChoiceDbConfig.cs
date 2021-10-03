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
    internal class ChoiceDbConfig : IEntityTypeConfiguration<Choice>
    {
        public virtual void Configure(EntityTypeBuilder<Choice> builder)
        {
            builder.HasIndex(choice => new { choice.CardId, choice.ElectionId });
            builder.HasIndex(choice => new { choice.GamerId, choice.ElectionId });

            builder.HasOne(choice => choice.Card)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(choice => choice.Gamer)
                .WithMany();
            
            builder.HasOne(choice => choice.Election)
                .WithMany(election => election.Choices)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
