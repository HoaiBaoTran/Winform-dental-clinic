using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.DTO
{
    internal class CheckFieldInfo
    {
        public static bool checkPhoneNumber(string phoneNumber)
        {
            const string pattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        public static bool checkEmail(string email)
        {
            Regex validateEmailRegex = new Regex(@"^([\w\.-]+)@([\w\-]+)((\.[a-zA-Z]{2,3})+)$");
            bool isValid = validateEmailRegex.IsMatch(email);

            if (isValid)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public static bool checkInteger(string number)
        {
            int numberCheck;
            if (int.TryParse(number, out numberCheck))
            {
                return true;
            }
            return false;
        }
    }
}
