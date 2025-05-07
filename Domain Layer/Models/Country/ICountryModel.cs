
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain_Layer.Models.Country;
public interface ICountryModel
{
    int Id { get; set; }
    string Name { get; }

}