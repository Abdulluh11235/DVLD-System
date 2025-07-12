using Domain_Layer;

namespace Service_Layer.Interfaces.Person
{
    public interface IPersonServices
    {
        int? AddPerson(PersonModel person);
        bool DeletePerson(int id);
       Task<  IEnumerable<PersonModel> > GetAllPeople();
        PersonModel? GetPersonById(int id);
        PersonModel? GetPersonByNationalNo(string nationalNo);
        bool UpdatePerson(PersonModel person);
        Task<IEnumerable<PersonModel> >GetByFirstName(string val);
        Task<IEnumerable<PersonModel>> GetByLastName(string vla);
        Task<IEnumerable<PersonModel>> GetByNationalNo(string vla);
    }
}