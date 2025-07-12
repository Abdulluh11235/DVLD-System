using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models.User
{
    public class UserModel 
    {

        [Range(0, int.MaxValue, ErrorMessage = "User ID cannot be less than zero.")]
        public int UserID { get; set; }

        [Browsable(false)]
        public required PersonModel Person { get; set; }

        [StringLength(20, MinimumLength= 4 )]
        public required string  UserName { get; set; }
        [StringLength(110, MinimumLength = 8, ErrorMessage = "Hashed Password Must Be Between 8 & 110")]
        [Browsable(false)]
        public required string HashedPassword { get; set; }
        public int PersonId { get => Person.PersonID; }
        public bool Active { get; set; }
    }
}
