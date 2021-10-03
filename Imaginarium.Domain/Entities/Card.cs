
using System;
using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Card : Entity
    {
        public string Name { set; get; }
        public Collection Collection { init; get; }
        public int? CollectionId { private set; get; }
        public IEnumerable<Deck> Decks { init; get; }
        public IEnumerable<Hand> Hands { init; get; }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   Name == card.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
