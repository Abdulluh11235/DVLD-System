using Domain_Layer;
using Service_Layer.Common_Services;
using Service_Layer.Interfaces.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Interfaces
{

    public class PersonServices : IPersonServices
    {
        private readonly IPersonRepository _personRepository;
        private readonly IModelDataAnnotationCheck _modelDataAnnotationCheck;
        public PersonServices(IPersonRepository personRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _personRepository = personRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public int? AddPerson(PersonModel person)
        {
            ValidateModel(person);
            return _personRepository.AddPerson(person);
        }

        public bool DeletePerson(int id)
        {
            if (id <= 0)
             throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _personRepository.DeletePerson(id);
        }


        public async Task< IEnumerable<PersonModel> > GetAllPeople()
        {
           return await _personRepository.GetAllPeople();
        }


        public async Task<IEnumerable<PersonModel>>  GetByFirstName(string val)
        {
            return await  _personRepository.GetByFirstName(val);
        }

        public async Task<IEnumerable<PersonModel>> GetByLastName(string val)
        {
            return await _personRepository.GetByLastName(val);
        }

        public async Task<IEnumerable<PersonModel>> GetByNationalNo(string val)
        {
            return await _personRepository.GetByNationalNo(val);
        }


        public PersonModel? GetPersonById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _personRepository.GetPersonById(id);
        }
        public PersonModel? GetPersonByNationalNo(string nationalNo) {
            if (nationalNo is null) throw new ArgumentNullException();
           
            return _personRepository.GetPersonByNationalNo(nationalNo);
        }

        public bool UpdatePerson(PersonModel person)
        {
            ValidateModel(person);
            return _personRepository.UpdatePerson(person);
        }
        public void ValidateModel(PersonModel personModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(personModel);
        }

     
    }
}
