using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class Lobby : IEntity
    {
        public int Id { set; get; }
        public IEnumerable<User> Users { set; get;}
        public Collection Collection { set; get; }
        public Game Game { set; get; }
    }
}
