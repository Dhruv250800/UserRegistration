using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class PasswordRule3Validator
    {
        public bool ValidateRule3(string password)
        {
            if (string.IsNullOrEmpty(password) || !password.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }
    }
}
