using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models.Country;

[DisplayColumn("Name")]
public class CountryModel : ICountryModel
{
    [Range(1, int.MaxValue, ErrorMessage = "CountryID cannot be less than zero.")]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Country Name is required.")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Country Name must be between 3 and 20 characters.")]
    public required string Name { get; init; }


}
