using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(GamerId), nameof(ElectionId), IsUnique = true)]
    [Index(nameof(CardId), nameof(ElectionId), IsUnique = true)]
    public abstract class Choice : IEntity
    {
        public int Id { set; get; }

        public Card Card { set; get; }
        public int CardId { set; get; }

        public Gamer Gamer { set; get; }
        public int? GamerId { set; get; }

        public Election Election { set; get; }
        public int ElectionId { set; get; }
    }
}
