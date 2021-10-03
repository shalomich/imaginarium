using System;
using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class User : Entity
    {    
        public string Name { set; get; }
        public Gamer Gamer { set; get; }
        public ISet<Collection> Collections { set; get; }
        public Lobby Lobby { set; get; }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Name == user.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
