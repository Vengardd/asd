using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Validators
{
    public class BookReleaseDateValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if ((DateTime)value > DateTime.Now)
            {
                return false;
            }
            return true;
        }
    }
}
