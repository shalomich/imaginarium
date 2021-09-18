using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class User : IEntity
    {
        public int Id { set; get; }
        
        [Required]
        public string Name { set; get; }
        public Gamer Gamer { set; get; }
        public IEnumerable<Collection> Collections { set; get; }
        public Lobby Lobby { set; get; }
    }
}
