using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Hand : Entity
    {
        public ISet<Card> Cards { set; get; }
        public Gamer Gamer { set; get; }
        public int GamerId { private set; get; }
    }
}
