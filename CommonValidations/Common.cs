using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonValidations
{
    /// <summary>
    /// Common check validations. 
    /// Please use, correct, share and update.
    /// Please follow single responsability pattern and naming convention.
    /// Thank you. 
    /// </summary>

    public static class Common
    {

        //Basic Email Validation using regular expressions.
        public static bool IsValidEmail(string input)
        {
            Regex r = new Regex(@"^([\w-\.]+)@((?:[\w]+\.)+)([a-zA-Z]{2,4})$");
            return r.IsMatch(input) ? true : false;
        }

        //Look for Ilegal char in string.
        public static bool HasSpecialChar(string specialCharList, string input)
        {
            //Example of a special char list.
            //eg. string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,.´`^";

            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) return true;
            }
            return false;
        }

        //Look for Ilegal char in string and returns it to the caller.
        public static string ReturnSpecialChar(string specialCharList, string input)
        {
            //Example of a special char list.
            //eg. string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,.´`^";

            string message = "";

            foreach (var item in specialCharList)
            {
                if (input.Contains(item)) message += item.ToString();
            }
            return message;

        }

        //Remove white spaces from a given string using regular expressions.
        public static string RemoveWhiteSpace(string input)
        {
            return input = Regex.Replace(input, @"\s+", "");
        }

        /// Checks if all characters are uppercase.
        public static bool IsUpper(string input)
        {
            string newString = Regex.Replace(input, @"[^A-Za-z0-9\s]", "");
            foreach (var item in newString)
            {
                if (!char.IsUpper(item)) return false;
            }
            return true;
        }

        /// Checks if it is a empty string.
        public static bool IsEmptyString(string input)
        {
            return input.Trim().Length == 0 ?  true : false;
        }
    }
}
