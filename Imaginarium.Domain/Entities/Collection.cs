using System;
using System.Collections.Generic;

namespace Imaginarium.Domain.Entities
{
    public class Collection : Entity
    {
        public string Name { set; get; }
        public ISet<Card> Cards { set; get; }
        public User User { init; get; }
        public int UserId { private set; get; }

        public override bool Equals(object obj)
        {
            return obj is Collection collection &&
                   Name == collection.Name &&
                   UserId == collection.UserId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, UserId);
        }
    }
}
