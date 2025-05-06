using Domain_Layer.Models.Country;

namespace Service_Layer.Interfaces.Country
{
    public interface ICountryServices
    {
        IEnumerable<ICountryModel> GetAllCountries();
        ICountryModel? GetCountryById(int id);
    }
}