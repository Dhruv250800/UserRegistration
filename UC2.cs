﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class LastNameValidator
    {
        public bool ValidateLastName(string lastName)
        {
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";
            return Regex.IsMatch(lastName, pattern);
        }
    }
}
