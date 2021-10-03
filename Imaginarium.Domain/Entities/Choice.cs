
namespace Imaginarium.Domain.Entities
{
    public abstract class Choice : Entity
    {
        public Card Card {init; get; }
        public int CardId { private set; get; }

        public Gamer Gamer { init; get; }
        public int? GamerId { private set; get; }

        public Election Election { init; get; }
        public int ElectionId { private set; get; }
    }
}
