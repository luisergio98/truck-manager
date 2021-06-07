using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManager.Models.Validation
{
    public class ManufactureDateAttribute : RegularExpressionAttribute
    {
        public ManufactureDateAttribute()
          : base(DateTime.Now.Year.ToString()) { }
    }
}
