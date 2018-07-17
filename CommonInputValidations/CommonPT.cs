using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CommonInputValidations
{

    ///Common Input Validations for Portuguese values. (eg. Phone, postal code, ssn, etc..)
    ///Remenber: Static methods only.
    ///Follow Single responsability pattern and naming convention.
    ///Remenber Keep it simple.
    ///Please use, share, correct and update. :)

    public static class CommonPT
    {
        //Check if is a valid Portuguese phone number pattern.
        public static bool IsPhoneNumberPT(string pnumber)
        {
            Regex num = new Regex(@"^[2|9|8|7]\d{8}$");
            return num.IsMatch(pnumber) ? true : false;
        }

        //Check if is a valid Portuguese Postal Code Pattern. (eg. 8125-153)
        public static bool IsPostalCodePT(string ptcode)
        {
            Regex pattern = new Regex(@"^([\d]{4})[-]{1}([\d]{3})$");
            return pattern.IsMatch(ptcode); 
        }

        //Check if its a valid Portuguese fiscal number.
        public static bool IsFiscaNumberPT(string ssn)
        {
            Regex pattern = new Regex(@"^([1|2|5|6|7|9])\d{8}$");
            return pattern.IsMatch(ssn);
        }
    }
}
