using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TruckManager.Models.Validation
{
    public class ModelDateAttribute : RegularExpressionAttribute
    {
        public ModelDateAttribute()
          : base(DateTime.Now.Year.ToString() + "|" + DateTime.Now.AddYears(1).Year.ToString()) { }
    }
}
