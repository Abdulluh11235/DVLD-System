using Domain_Layer.Models.Country;
using System.ComponentModel;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Infrastructure Layer")]

namespace Domain_Layer
{
    public interface IPersonModel
    {
        [DisplayName("Person ID")]
        int PersonID { get; set; }
        [DisplayName("First Name")]
        string FirstName { get; set; }
        [DisplayName("Second Name")]
        string SecondName { get; set; }
        [DisplayName("Third Name")]
        string? ThirdName { get; set; }
        [DisplayName("Last Name")]
        string LastName { get; set; }
        bool Gender { get; set; }
        [DisplayName("Date Of Birth")]
        DateTime DateOfBirth { get; set; }

        [DisplayName("National No.")]
        string NationalNo { get; set; }
        string Address { get; set; }
        ICountryModel Country { get; set; }
       
        [DisplayName("Country Name")]
       public string CountryName { get; }

        string? Email { get; set; }
        string Phone { get; set; }

        [DisplayName("Image Path")]
        string? ImagePath { get; set; }
    }
}