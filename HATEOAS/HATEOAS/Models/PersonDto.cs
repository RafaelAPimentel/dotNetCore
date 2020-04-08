using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HATEOAS.Models
{
    public class PersonDto : Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
