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

        public async Task< IEnumerable<CountryModel> > GetAllCountries()
        {
            return await _countryRepository.GetAllCountries();
        }

        public CountryModel? GetCountryById(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be greater than zero.");

            return _countryRepository.GetCountryById(id);
        }
    }
}
