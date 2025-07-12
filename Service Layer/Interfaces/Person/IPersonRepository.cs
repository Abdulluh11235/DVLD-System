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
        int? AddPerson(PersonModel person);
        bool DeletePerson(int id);
       Task< IEnumerable<PersonModel> >GetAllPeople();
       Task< IEnumerable<PersonModel> > GetByFirstName(string val);
       Task< IEnumerable<PersonModel> >GetByLastName(string vla);
       Task< IEnumerable<PersonModel> >GetByNationalNo(string vla);

        PersonModel? GetPersonById(int id);
        PersonModel? GetPersonByNationalNo(string nationalNo);

        bool UpdatePerson(PersonModel person);
    }
}
