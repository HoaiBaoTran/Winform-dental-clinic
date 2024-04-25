using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using N19_DentalClinic.model;
using N19_DentalClinic.GUI.ReceptionistView;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Text.RegularExpressions;

namespace N19_DentalClinic.GUI.Work_schedule
{
    public partial class AddCalendarToEmployee : Form
    {
        public static Color color;
        private string EmployID;
        DataInteraction data = new DataInteraction();
        Panel panelWrapper;
        int role;
        string interaction;

        private string currday;
        private string startTimePicker;
        private string endTimePicker;

        private void AddEvents_Load(object sender, EventArgs e)
        {
            //Hien thi thong tin lịch làm việc can chinh sua
            if(interaction == "update")
            {
                lbCalendar.Text = "Sửa lịch làm việc";
                // Parse the string as a DateTime object using the specified format
                DateTime parsedDate = DateTime.ParseExact(currday, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                // Set the DateTimePicker text with the parsed date, ensuring it matches the format
                dtpDayWork.Value = parsedDate;

                // If you only want to update the displayed text without affecting the internal value:
                dtpDayWork.Text = parsedDate.ToString();

                try
                {
                    //TimeStart
                    // Parse the time string as a TimeSpan object using the specified format
                    TimeSpan parsedTimeStart = TimeSpan.ParseExact(startTimePicker, "g", null, TimeSpanStyles.AssumeNegative);
                    // Create a temporary DateTime object with today's date and the parsed time
                    DateTime tempDateTimeStart = DateTime.Today.Add(parsedTimeStart);
                    dtpTimeStart.Text = parsedTimeStart.ToString();
                    dtpTimeStart.Value = tempDateTimeStart;

                }
                finally
                {

                }

                try
                {
                    //TimeEnd
                    // Parse the time string as a TimeSpan object using the specified format
                    TimeSpan parsedTimeEnd = TimeSpan.ParseExact(endTimePicker, "g", null, TimeSpanStyles.AssumeNegative);

                    // Create a temporary DateTime object with today's date and the parsed time
                    DateTime tempDateTimeEnd = DateTime.Today.Add(parsedTimeEnd);

                    // Set the DateTimePicker value with the temporary DateTime object
                    dtpTimeEnd.Value = tempDateTimeEnd;
                    dtpTimeEnd.Text = parsedTimeEnd.ToString();
                }
                finally
                {

                }
            }
        }


        public AddCalendarToEmployee(string EmployID, Panel panelWrapper, int role, string interaction, string currday, string startIme, string endTime)
        {
            InitializeComponent();
            this.EmployID = EmployID;
            this.panelWrapper = panelWrapper;
            this.role = role;
            this.interaction = interaction;
            this.currday = currday;
            this.startTimePicker = startIme;
            this.endTimePicker = endTime;
        }



        private void dtpDayWork_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpTimeStart_ValueChanged_1(object sender, EventArgs e)
        {
            dtpTimeStart.Value = new DateTime(
                 dtpDayWork.Value.Year,
                 dtpDayWork.Value.Month,
                 dtpDayWork.Value.Day,
                 dtpTimeStart.Value.Hour,
                 dtpTimeStart.Value.Minute,
                 0);
        }

        private void dtpTimeEnd_ValueChanged_1(object sender, EventArgs e)
        {
            dtpTimeEnd.Value = new DateTime(
                  dtpDayWork.Value.Year,
                  dtpDayWork.Value.Month,
                  dtpDayWork.Value.Day,
                  dtpTimeEnd.Value.Hour,
                  dtpTimeEnd.Value.Minute,
                  0);
        }

        private bool IsEventTimeConflict(DateTime startTime, DateTime endTime, DataTable existingEvents)
        {
            foreach (DataRow row in existingEvents.Rows)
            {
                DateTime existingStartTime = (DateTime)row["timeStart"];
                DateTime existingEndTime = (DateTime)row["timeEnd"];

                // Kiểm tra xem khoảng thời gian muốn thêm vào có trùng với bất kỳ sự kiện nào đã tồn tại không
                if (  !((existingEndTime<startTime) || (existingStartTime>endTime)))
                {
                    return true; // Trùng khớp
                }
            }
            return false; // Không trùng khớp
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            DateTime startTime = dtpTimeStart.Value;
            DateTime endTime = dtpTimeEnd.Value;

            // Kiểm tra xem thời gian kết thúc có sau thời gian bắt đầu không
            if (endTime <= startTime)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu!");
                return;
            }



            //Kiem tra thoi gian co trung voi lich lam viec khong

            string sqlCalendar;


            if(interaction == "update")
            {
                if (EmployID.Contains("DE"))
                {
                    sqlCalendar = @$"SELECT * FROM Calendar_Dentist WHERE able = 1 and DenID = '{EmployID}' 
                        and CONVERT(varchar(10), dayWorks, 103) = '{currday}'
                        and not exists
                        (select * from Calendar_Dentist where able = 1 and DenID = '{EmployID}' 
                            and CONVERT(varchar(10), dayWorks, 103) = '{currday}' 
                            and CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}'
                            and CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}')";
                }
                else if (EmployID.Contains("AS"))
                {
                    sqlCalendar = @$"SELECT * FROM Calendar_Assisstant WHERE able = 1 and AssiID = '{EmployID}' 
                        and CONVERT(varchar(10), dayWorks, 103) = '{currday}'
                        and not exists
                        (select * from Calendar_Assisstant where able = 1 and AssiID = '{EmployID}' 
                            and CONVERT(varchar(10), dayWorks, 103) = '{currday}' 
                            and CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}'
                            and CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}')";
                }
                else
                {
                    sqlCalendar = @$"SELECT * FROM Calendar_Receptionist WHERE able = 1 and RecepID = '{EmployID}' 
                        and CONVERT(varchar(10), dayWorks, 103) = '{currday}'
                        and not exists
                        (select * from Calendar_Receptionist where able = 1 and RecepID = '{EmployID}' 
                            and CONVERT(varchar(10), dayWorks, 103) = '{currday}' 
                            and CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}'
                            and CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}')";
                }
            }
            else { 
                if(EmployID.Contains("DE"))
                {
                    sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Dentist WHERE able = 1 and DenID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
                }
                else if(EmployID.Contains("AS"))
                {
                    sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Assisstant WHERE able = 1 and AssiID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
                }
                else
                {
                    sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Receptionist WHERE able = 1 and RecepID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
                }
            }

            
            
            
            DataTable tableCalendar = data.readData(sqlCalendar);
            if (IsEventTimeConflict(startTime, endTime, tableCalendar))
            {
                MessageBox.Show("Thời gian bị trùng với lịch làm việc đã có");
                return;
            }
            
            if(interaction == "update")
            {
                string sqlUpdateCalendar = "";
                // Thêm sự kiện vào cơ sở dữ liệu nếu không có trùng khớp
                if (EmployID.Contains("DE"))
                {
                    sqlUpdateCalendar = @$"update calendar_dentist 
                        set dayWorks = '{dtpDayWork.Value.Date}',
                            timeStart = '{startTime}',          
                            timeEnd = '{endTime}'
                        where denid = '{EmployID}' and
                            CONVERT(varchar(10), dayWorks, 103) = '{currday}' and 
                            CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}' and
                            CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}'";
                }
                else if (EmployID.Contains("AS"))
                {
                    sqlUpdateCalendar = @$"update Calendar_Assisstant 
                        set dayWorks = '{dtpDayWork.Value.Date}',
                            timeStart = '{startTime}',          
                            timeEnd = '{endTime}'
                        where assiid = '{EmployID}' and
                            CONVERT(varchar(10), dayWorks, 103) = '{currday}' and 
                            CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}' and
                            CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}'";
                }
                else
                {
                    sqlUpdateCalendar = @$"update Calendar_ReCeptionist 
                        set dayWorks = '{dtpDayWork.Value.Date}',
                            timeStart = '{startTime}',          
                            timeEnd = '{endTime}'
                        where recepid = '{EmployID}' and
                            CONVERT(varchar(10), dayWorks, 103) = '{currday}' and 
                            CONVERT(varchar(8), timeStart, 108) = '{startTimePicker}' and
                            CONVERT(varchar(8), timeEnd, 108) = '{endTimePicker}'";
                }
                data.changeData(sqlUpdateCalendar);
            }
            else
            {
                string sqlAddCalendar = "";
                // Thêm sự kiện vào cơ sở dữ liệu nếu không có trùng khớp
                if (EmployID.Contains("DE"))
                {
                    sqlAddCalendar = $"INSERT INTO Calendar_Dentist(DenID, dayWorks, timeStart, timeEnd) VALUES ('{EmployID}', '{dtpDayWork.Value.Date}', '{startTime}', '{endTime}')";
                }
                else if (EmployID.Contains("AS"))
                {
                    sqlAddCalendar = $"INSERT INTO Calendar_Assisstant(AssiID, dayWorks, timeStart, timeEnd) VALUES ('{EmployID}', '{dtpDayWork.Value.Date}', '{startTime}', '{endTime}')";
                }
                else
                {
                    sqlAddCalendar = $"INSERT INTO Calendar_ReCeptionist(Recepid, dayWorks, timeStart, timeEnd) VALUES ('{EmployID}', '{dtpDayWork.Value.Date}', '{startTime}', '{endTime}')";
                }
                data.changeData(sqlAddCalendar);
            }
            MessageBox.Show("Đã lưu thành công! Vui lòng ở trang lịch làm việc và nhấn tuần này để cập nhật thông tin mới nhất");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
