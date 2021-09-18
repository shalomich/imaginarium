using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Persistance.Entities
{
    public class Association : IEntity
    {
        public int Id { set; get; }
     
        [Required]
        public string Phrase { set; get; }
        public Nominee Nominee { set; get; }
        public int? NomineeId { set; get; }
        public Round Round { set; get; }
        public int RoundId { set; get; }
    }
}
