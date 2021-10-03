using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Lobby : Entity
    {
        public ISet<User> Users { init; get;}
        public Collection Collection { set; get; }
        public Game Game { set; get; }
    }
}
