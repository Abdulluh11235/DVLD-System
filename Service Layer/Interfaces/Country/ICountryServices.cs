using Domain_Layer.Models.Country;

namespace Service_Layer.Interfaces.Country
{
    public interface ICountryServices
    {
       Task< IEnumerable<CountryModel> >GetAllCountries();
        CountryModel? GetCountryById(int id);
    }
}