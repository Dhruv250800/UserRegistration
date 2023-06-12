using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class FirstNameValidator
    {
        public bool ValidateFirstName(string firstName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(firstName, pattern);
        }
    }
}
