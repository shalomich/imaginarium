using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(Name), nameof(UserId), IsUnique = true)]
    public class Collection : IEntity
    {
        public int Id { set; get; }
        
        [Required]
        public string Name { set; get; }
        public IEnumerable<Card> Cards { set; get; }
        public User User { set; get; }
        public int UserId { set; get; }
        public IEnumerable<Lobby> Lobbies { set; get; }

    }
}
