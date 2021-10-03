
namespace Imaginarium.Domain.Entities
{
    public class Association : Entity
    {
        public string Phrase { init; get; }
        public Nominee Nominee { init; get; }
        public int? NomineeId { private set; get; }
        public Round Round { set; get; }
        public int RoundId { private set; get; }
    }
}
