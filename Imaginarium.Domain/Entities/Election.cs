using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Election : Entity
    {
        public IEnumerable<Choice> Choices { init; get; }
        public Round Round { init; get; }
        public int RoundId { private set; get; }
    }
}
