
using System.ComponentModel;

namespace Domain_Layer.Models.Country
{
    public interface ICountryModel
    {
        int Id { get; set; }
        string Name { get; }

    }
}