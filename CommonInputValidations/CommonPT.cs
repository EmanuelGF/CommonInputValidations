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
    ///Please use, share, correct and update. :)

    public static class CommonPT
    {

        //Check if is a valid Portuguese phone number.
        public static bool IsPhoneNumberPT(string number)
        {
            Regex num = new Regex(@"^[2|9|8|7]\d{8}$");
            return num.IsMatch(number) ? true : false;
        }
    }
}
