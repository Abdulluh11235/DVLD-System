using Domain_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Interfaces.Person
{
    public interface IPersonRepository
    {
        int? AddPerson(IPersonModel person);
        bool DeletePerson(int id);
        IEnumerable<IPersonModel> GetAllPeople();
        IPersonModel? GetPersonById(int id);
        bool UpdatePerson(IPersonModel person);
    }
}
