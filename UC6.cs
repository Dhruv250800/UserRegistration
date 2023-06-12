using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class PasswordRule2Validator
    {
        public bool ValidateRule2(string password)
        {
            if (string.IsNullOrEmpty(password) || !password.Any(char.IsUpper))
            {
                return false;
            }
            return true;
        }
    }
}
