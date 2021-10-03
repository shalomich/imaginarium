using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imaginarium.Domain.Entities
{
    public class Nominee : Choice
    {
        public Association Association { init; get;}
    }
}
