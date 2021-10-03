
using System;

namespace Imaginarium.Domain.Entities
{
    public class Gamer : Entity
    {
        public string UserName {private set; get; }
        public User User { init; get; }
        public int Score { set; get; }
        public bool IsPresenter { set; get; }
        public Hand Hand { init; get; }
        public Game Game { init; get; }
        public int GameId {private set; get; }

        public override bool Equals(object obj)
        {
            return obj is Gamer gamer &&
                   UserName == gamer.UserName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UserName);
        }
    }
}
