using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class Round : IEntity
    {
        public int Id { set; get; }
        public int Number { set; get; }
        public Association Association { set; get; }
        public Voting Voting { set; get; }
        public Election Election { set; get; }
        public Game Game { set; get; }
        public int GameId { set; get; }
    }
}
