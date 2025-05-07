using System.ComponentModel.DataAnnotations;

namespace Domain_Layer.Models.User
{
    public interface IUserModel
    {
        int UserID { get; set; }
        bool Active { get; set; }
        string HashedPassword { get; set; }
      
        PersonModel Person { get; set; }
    }
}