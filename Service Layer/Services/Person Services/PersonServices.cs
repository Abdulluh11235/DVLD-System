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

        public int? AddPerson(IPersonModel person)
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


        public IEnumerable<IPersonModel> GetAllPeople()
        {
           return _personRepository.GetAllPeople();
        }


        public IEnumerable<IPersonModel> GetByFirstName(string val)
        {
            NoEmptyORNull(val);
            return  _personRepository.GetByFirstName(val);
        }

        public IEnumerable<IPersonModel> GetByLastName(string val)
        {
            NoEmptyORNull(val); 
            return _personRepository.GetByLastName(val);
        }

        public IEnumerable<IPersonModel> GetByNationalNo(string val)
        {
            NoEmptyORNull(val);
            return _personRepository.GetByNationalNo(val);
        }


        public IPersonModel? GetPersonById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");
            return _personRepository.GetPersonById(id);
        }

        public bool UpdatePerson(IPersonModel person)
        {
            ValidateModel(person);
            return _personRepository.UpdatePerson(person);
        }
        public void ValidateModel(IPersonModel personModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(personModel);
        }

        private void NoEmptyORNull(string str)
        {
            if (string.IsNullOrWhiteSpace(str))  
                throw new ArgumentException("The input cannot be empty,", nameof(str));
        }
    }
}
