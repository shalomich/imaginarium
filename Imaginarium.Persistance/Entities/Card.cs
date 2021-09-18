using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    [Index(nameof(Name), nameof(CollectionId),IsUnique = true)]
    public class Card : IEntity
    {
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }
        public Collection Collection { set; get; }
        public int CollectionId { set; get; }
        
    }
}
