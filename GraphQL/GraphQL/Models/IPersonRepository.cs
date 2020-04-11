using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();
        Person GetOne(int id);
    }
}
