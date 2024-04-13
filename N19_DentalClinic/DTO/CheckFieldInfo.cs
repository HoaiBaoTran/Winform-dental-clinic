using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace N19_DentalClinic.DTO
{
    internal class CheckFieldInfo
    {
        public static bool checkPhoneNumber(string phoneNumber)
        {
            int n;
            bool isNumeric = int.TryParse(phoneNumber, out n);
            if(!isNumeric)
            {
                return false;
            }
            if(phoneNumber.Length <10) { return false; }
            return true;
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
            if (Int32.TryParse(number, out numberCheck))
            {
                return true;
            }
            return false;
        }
    }
}
