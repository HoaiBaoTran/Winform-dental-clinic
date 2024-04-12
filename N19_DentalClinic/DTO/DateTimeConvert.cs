using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_ProjectForm.DAO
{
    public class DateTimeConvert
    {
        public static string convertDMY(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("dd/MM/yyyy");
        }

        public static string convertMDY(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("MM/dd/yyyy");
        }

        public static string convertHMS(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.ToString($"{myDateTime:HH}:{myDateTime:mm}:{myDateTime:ss}");
        }

        public static string convertSqlTime(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("yyyy-MM-dd hh:mm:ss");
        }

        public static string convertSqlTimeDay(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("yyyy-MM-dd");
        }
    }
}
