using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(GameId), IsUnique = true)]
    public class Deck : IEntity
    {
        public int Id { set; get; }
        public IEnumerable<Card> Cards { set; get; }
        public Game Game { set; get; }
        public int GameId { set; get; }
    }
}
