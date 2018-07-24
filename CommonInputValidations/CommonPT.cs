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
        /// <summary>
        /// Check if is a valid Portuguese phone number pattern.
        /// </summary>
        public static bool IsPhoneNumberPT(string pnumber)
        {
            Regex num = new Regex(@"^[2|9|8|7]\d{8}$");
            return num.IsMatch(pnumber) ? true : false;
        }


        /// <summary>
        /// Check if is a valid Portuguese Postal Code Pattern. (eg. 8125-153)
        /// </summary>
        public static bool IsPostalCodePT(string ptcode)
        {
            Regex pattern = new Regex(@"^([\d]{4})[-]{1}([\d]{3})$");
            return pattern.IsMatch(ptcode); 
        }

        /// <summary>
        /// Check if its a valid Portuguese fiscal number.
        /// </summary>
        public static bool IsFiscaNumberPT(string ssn)
        {
            Regex pattern = new Regex(@"^([1|2|5|6|7|9])\d{8}$");
            return pattern.IsMatch(ssn);
        }

        /// <summary>
        /// Check if its a valid Portuguese Social Security number.
        /// </summary>
        public static bool IsSocialSecurityNumPT(string niss)
        {
            Regex pattern = new Regex(@"^([1])\d{10}$");
            return pattern.IsMatch(niss);
        }
    }
}
