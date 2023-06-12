using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class PasswordRule4Validator
    {
        public bool ValidateRule4(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return false;
            }

            int specialCharCount = 0;
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    specialCharCount++;
                }
            }

            if (specialCharCount == 1)
            {
                return true;
            }

            return false;
        }
    }
}
