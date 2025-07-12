using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models.Application
{
    public class ApplicationTypeModel
    {
    
       public int Id { get; set; }
        [StringLength(40, MinimumLength = 6, 
         ErrorMessage = "Type Name must be between 6 and 40 characters.")]
        public required string Name { get; set; }
        public  int Fees { get; set; }

    }
}
