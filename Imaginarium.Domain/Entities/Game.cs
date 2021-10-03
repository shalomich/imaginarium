using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Domain.Entities
{
    public class Game : Entity
    {
        public Deck Deck { init; get;}
        public ISet<Gamer> Gamers { init; get; }
        public ISet<Round> Rounds  { init; get; }
        public Lobby Lobby { init; get; }
        public int LobbyId { private set; get; }
    }
}
