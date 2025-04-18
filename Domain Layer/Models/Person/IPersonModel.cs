using Domain_Layer.Models.Country;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Infrastructure Layer")]

namespace Domain_Layer
{
    public interface IPersonModel
    {
        string Address { get; set; }
        ICountryModel Country { get; set; }
        DateTime DateOfBirth { get; set; }
        string? Email { get; set; }
        string FirstName { get; set; }
        bool Gender { get; set; }
        string? ImagePath { get; set; }
        string LastName { get; set; }
        string NationalNo { get; set; }
        int PersonID { get; set; }
        string Phone { get; set; }
        string SecondName { get; set; }
        string? ThirdName { get; set; }
    }
}