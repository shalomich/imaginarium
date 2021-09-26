using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(GamerId), nameof(VotingId), IsUnique = true)]
    public class Vote : IEntity
    {
        public int Id { set; get; }
        public Choice Choice { set; get; }
        public int? ChoiceId { set; get; }
        public Gamer Gamer { set;get;}
        public int? GamerId { set; get; }
        public Voting Voting { set; get; }
        public int VotingId { set; get; }
    }
}
