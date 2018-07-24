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

        /// <summary>
        /// Basic Email check using regular expression.
        /// </summary>
        public static bool IsEmail(string input)
        {
            Regex pattern = new Regex(@"^([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})$");
            return pattern.IsMatch(input) ? true : false;
        }

        /// <summary>
        /// Checks for Ilegal char's in input string.
        /// </summary>
        public static bool HasSpecialChar(string specialCharList, string input)
        {
            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }

        /// <summary>
        /// Returns any special Char in a given string.
        /// </summary>
        public static string ReturnSpecialChar(string specialCharList, string input)
        {
            string message = "";
            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) message += item.ToString();
            }
            return message;
        }

        /// <summary>
        /// Remove all white space from a given string.
        /// </summary>
        public static string RemoveWhiteSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", "");
        }

        /// <summary>
        /// Check if string contains only letters.
        /// </summary>
        public static bool IsOnlyLetters(string input)
        {
            Regex pattern = new Regex("^[a-zA-Z]*$");
            return pattern.IsMatch(input) ? true : false;
        }

    }
}
