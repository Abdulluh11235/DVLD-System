using Domain_Layer.Models.Country;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
namespace Domain_Layer
{
    public class PersonModel : IPersonModel
    {
       [Range(1, int.MaxValue, ErrorMessage = "PersonID cannot be less than zero.")]
       public int PersonID { get; set; }

        [Required(ErrorMessage = "National Number is required.")]
        [StringLength(20, MinimumLength = 10, ErrorMessage = "National Number must be between 10 and 20 characters.")]
        public required string NationalNo { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First Name must be between 3 and 20 characters.")]
        public required string FirstName { get; set; }

        [Required(ErrorMessage = "Second Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Second Name must be between 3 and 20 characters.")]
        public required string SecondName { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Third Name must be between 3 and 20 characters.")]
        public string? ThirdName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 20 characters.")]
        public required string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")]
        public required DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public required bool Gender { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "Address must be between 10 and 200 characters.")]
        public required string Address { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number format.")]
        public required string Phone { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public required ICountryModel Country { get; set; }

        [StringLength(250, ErrorMessage = "Image Path cannot be longer than 250 characters.")]
        public string? ImagePath { get; set; }

    }
}
