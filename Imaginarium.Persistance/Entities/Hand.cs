using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(GamerId), IsUnique = true)]
    public class Hand : IEntity
    {
        public int Id { set; get; }
        public IEnumerable<Card> Cards { set; get; }
        public Gamer Gamer { set; get; }
        public int GamerId { set; get;}
    }
}
