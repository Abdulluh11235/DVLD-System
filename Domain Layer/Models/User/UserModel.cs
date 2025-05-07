using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models.User
{
    public class UserModel : IUserModel
    {

        [Range(0, int.MaxValue, ErrorMessage = "User ID cannot be less than zero.")]
        public int UserID { get; set; }
        public required PersonModel Person { get; set; }
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Hashed Password Must Be Between 8 & 50")]
        [Browsable(false)]
        public required string HashedPassword { get; set; }
        public bool Active { get; set; }
    }
}
