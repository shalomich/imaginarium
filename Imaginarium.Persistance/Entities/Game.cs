using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class Game : IEntity
    {
        public int Id { set; get; }
        public Deck Deck { set; get;}
        public IEnumerable<Gamer> Gamers { set; get; }
        public IEnumerable<Round> Rounds  { set; get; }
        public Lobby Lobby { set; get; }
        public int LobbyId { set; get; }
    }
}
