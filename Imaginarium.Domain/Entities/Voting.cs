using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Voting : Entity
    {
        public IEnumerable<Vote> Votes { set; get; }
        public Round Round { set; get; }
        public int RoundId { private set; get; }
    }
}
