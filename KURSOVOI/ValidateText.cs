using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace KURSOVOI
{
    public class ValidateText
    {
        ValidateText() { }

        public static bool Validate(string s)
        {
            return Regex.IsMatch(s, @"^[A-Za-z0-9]+$");
        }

        public static bool ValidateCust(string s)
        {
            return Regex.IsMatch(s, @"^[0-9]+$");
        }

        public static bool ValidateCustm(string s)
        {
            return Regex.IsMatch(s, @"^[A-Za-z]+$");
        }

        public static bool ValidateEmail(string s)
        {
            return Regex.IsMatch(s, @"^[A-Za-z][A-Za-z0-9!@#$%^&*]*$");
        }

        public static bool ValidateStrings(string s)
        {
            return Regex.IsMatch(s, @"^[A - Za - z][^.] * $");
        }
    }
}
