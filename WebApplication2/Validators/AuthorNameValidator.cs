using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication2.Validators
{
    public class AuthorNameValidator : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            Regex regex = new Regex(@"^[A-Za-z][A-Za-z0-9 -]*$/");
            if (!regex.IsMatch(value.ToString()))
            {
                return false;
            }
            return true;
        }
    }
}
