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
    internal class AssociationDbConfig : IEntityTypeConfiguration<Association>
    {
        public void Configure(EntityTypeBuilder<Association> builder)
        {
            builder.Property(association => association.Phrase).IsRequired();

            builder.HasOne(association => association.Round)
                .WithOne(round => round.Association)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(association => association.Nominee)
                .WithOne(nominee => nominee.Association);
        }
    }
}
