using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Deck : Entity
    {
        public ISet<Card> Cards { init; get; }
        public Game Game { init; get; }
        public int GameId { private set; get; }
    }
}
