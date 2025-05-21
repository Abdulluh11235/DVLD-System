using Domain_Layer;

namespace Service_Layer.Interfaces.Person
{
    public interface IPersonServices
    {
        int? AddPerson(IPersonModel person);
        bool DeletePerson(int id);
      Task<  IEnumerable<IPersonModel> > GetAllPeople();
        IPersonModel? GetPersonById(int id);
        bool UpdatePerson(IPersonModel person);
        IEnumerable<IPersonModel> GetByFirstName(string val);
        IEnumerable<IPersonModel> GetByLastName(string vla);
        IEnumerable<IPersonModel> GetByNationalNo(string vla);
    }
}