using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonValidations
{
    /// <summary>
    /// Common Input Validations for Portuguese Data.
    /// (eg. Phone number, Postal code, ssn etc...)
    /// 
    /// Please follow single responsability pattern and naming convention.
    /// Please use, share, correct and update ;)
    /// </summary>
    /// 

    public static class CommonPT
    {
        //Check if it is a Portuguese Phone number that has 9 digits and starts with 2 or 9.
        public static bool IsPhoneNumberPT(string number)
        {
            Regex num = new Regex(@"^[2|9|7|8]\d{8}$");
            return num.IsMatch(number) ? true : false;
        }


    }
}
