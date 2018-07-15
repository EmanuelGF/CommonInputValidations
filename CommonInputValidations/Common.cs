using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonInputValidations
{

    ///Common Input Validations used in most cases.
    ///Remenber: Static methods only.
    ///Follow Single responsability pattern and naming convention.
    ///Please use, share, correct and update. :)


    public static class Common
    {

        //Basic Email check using regular expression.
        public static bool IsEmail(string input)
        {
            Regex r = new Regex(@"^([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})$");
            return r.IsMatch(input) ? true : false;
        }
        
        /// Checks for Ilegal char's in input string.
        public static bool HasSpecialChar(string specialCharList, string input)
        {
            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }

        // Returns any special Char in a given string.
        public static string ReturnSpecialChar(string specialCharList, string input)
        {
            string message = "";

            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) message += item.ToString();
            }
            return message;
        }

        //Remove all white space.
        public static string RemoveWhiteSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }
    }
}
