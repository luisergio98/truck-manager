using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TruckManager.Models.Validation;

namespace TruckManager.Models
{
    public class TruckModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Truck Model")]
        [RegularExpression("FH|FM", ErrorMessage = "The model must be FH or FM")]
        public string Model { get; set; }
        [Display(Name = "Manufacture Year")]
        [ManufactureDate(ErrorMessage = "The manufacture year must be the current year")]
        public int ManufactureYear { get; set; }
        [Display(Name = "Model Year")]
        [ModelDate(ErrorMessage = "The model year must be the current year or the next one")]
        public int ModelYear { get; set; }
    }
}
