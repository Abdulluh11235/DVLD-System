using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models.Test;
public class TestTypeModel
{
    public int Id { get; set; }
    [StringLength(40, MinimumLength = 6,
     ErrorMessage = "Type Name must be between 6 and 40 characters.")]
    public required string Name { get; set; }
    public int Fees { get; set; }

    [StringLength(450, MinimumLength =20,
   ErrorMessage = "Type Description must be between 20 and 460 characters.")]
    public required string Description { get; set; }
}
