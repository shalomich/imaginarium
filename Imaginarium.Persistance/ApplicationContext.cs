using Imaginarium.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users {set; get;}
        public DbSet<Card> Cards {set; get;}
        public DbSet<Collection> Collections { set; get; }
        public DbSet<Lobby> Lobbies { set; get; }
        public DbSet<Game> Games {set; get;}
        public DbSet<Gamer> Gamers { set; get; }
        public DbSet<Round> Rounds { set; get; }

        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
