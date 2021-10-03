using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Domain.Entities
{
    public class Round : Entity
    {
        public int Number { init; get; }
        public Association Association { init; get; }
        public Voting Voting { set; get; }
        public Election Election { set; get; }
        public Game Game { init; get; }
        public int GameId { private set; get; }

        public override bool Equals(object obj)
        {
            return obj is Round round &&
                   Number == round.Number &&
                   GameId == round.GameId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Number, GameId);
        }
    }
}
