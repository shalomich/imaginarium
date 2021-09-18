using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(UserId), IsUnique = true)]
    [Index(nameof(GameId), IsUnique = true)]
    public class Gamer : IEntity
    {
        public int Id { set; get; }
        public int Score { set; get; }
        public bool IsPresenter { set; get; }
        public Hand Hand { set; get; }
        public User User { set; get; }
        public int UserId { set; get; }
        public Game Game { set; get; }
        public int GameId { set; get; }
     }
}
