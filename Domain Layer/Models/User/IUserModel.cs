using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Domain_Layer.Models.User
{
    public interface IUserModel
    {

        [DisplayName("User ID")]
        int UserID { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }
        [DisplayName("Person ID")]
        public int PersonId { get ; }
        bool Active { get; set; }
        string HashedPassword { get; set; }
        IPersonModel Person { get; set; }

    }
}