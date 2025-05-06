using Domain_Layer.Models.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Interfaces.Country
{
    public class CountryServices : ICountryServices
    {
        ICountryRepository _countryRepository;
        public CountryServices(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IEnumerable<ICountryModel> GetAllCountries()
        {
            return _countryRepository.GetAllCountries();
        }

        public ICountryModel? GetCountryById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");

            return _countryRepository.GetCountryById(id);
        }
    }
}
