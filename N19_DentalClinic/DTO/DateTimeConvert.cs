using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.DAO
{
    public class DateTimeConvert
    {
        //Chuyển chuỗi sang ngày tháng năm
        public static string convertDMY(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("dd/MM/yyyy");
        }

        //Chuyển chuỗi sang tháng ngày năm

        public static string convertMDY(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("MM/dd/yyyy");
        }

        //Chuyển chuỗi sang giờ phút giây
        public static string convertHMS(string day)
        {
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.ToString($"{myDateTime:HH}:{myDateTime:mm}:{myDateTime:ss}");
        }

        public static string convertSqlTimeForDDMMYYYY(string day)
        {
            DateTime date = DateTime.ParseExact(day, "dd/MM/yyyy", null);
            return date.Date.ToString("yyyy-MM-dd hh:mm:ss");
        }

        //Chuyển dữ liệu sang giờ mặc định trong database cho mục chọn ngày 
        public static string convertSqlTime(string day)
        {
            //DateTime myDateTime = DateTime.ParseExact(day,"dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime myDateTime = Convert.ToDateTime(day);
            return myDateTime.Date.ToString("yyyy-MM-dd hh:mm:ss");
        }


        //Chuyển dữ liệu sang ngày trong database
        public static string convertSqlTimeDay(string day) { 
            DateTime myDateTime = DateTime.ParseExact(day, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            return myDateTime.ToString("yyyy-MM-dd");
        }

        //Kiem tra thoi gian tuong lai
        public static bool isFuture(string myday)
        {
            DateTime myDateTimeDay = Convert.ToDateTime(convertSqlTimeDay(myday));
            int result = DateTime.Compare(myDateTimeDay, DateTime.Now);
            if (result > 0)
            {
                return true;
            }
            return false;
        }


        //Kiem tra thoi gian qua khu

        public static bool isPast(string myday)
        {
            DateTime myDateTimeDay = Convert.ToDateTime(convertSqlTimeDay(myday));
            int result = DateTime.Compare(myDateTimeDay, DateTime.Now);
            if (result < 0)
            {
                return false;
            }
            return true;
        }
    }
}
