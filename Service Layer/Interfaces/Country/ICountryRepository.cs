using Domain_Layer.Models.Country;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.Interfaces.Country
{
    public interface ICountryRepository
    {
        IEnumerable<ICountryModel> GetAllCountries();
        ICountryModel? GetCountryById(int id);
    }
}
