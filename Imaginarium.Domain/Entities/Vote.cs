
namespace Imaginarium.Domain.Entities
{
    public class Vote : Entity
    {
        public Choice Choice { set; get; }
        public int? ChoiceId { set; get; }
        public Gamer Gamer { set;get;}
        public int? GamerId { set; get; }
        public Voting Voting { set; get; }
        public int VotingId { set; get; }
    }
}
