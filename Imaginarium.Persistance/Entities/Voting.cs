using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class Voting : IEntity
    {
        public int Id { set; get; }
        public IEnumerable<Vote> Votes { set; get; }
        public Round Round { set; get; }
        public int RoundId { set; get; }
    }
}
