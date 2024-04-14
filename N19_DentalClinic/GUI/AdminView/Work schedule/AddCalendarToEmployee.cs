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

        private void AddEvents_Load(object sender, EventArgs e)
        {

        }


        public AddCalendarToEmployee(string EmployID, Panel panelWrapper, int role, string interaction)
        {
            InitializeComponent();
            this.EmployID = EmployID;
            this.panelWrapper = panelWrapper;
            this.role = role;
            this.interaction = interaction;
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
                if ((startTime > existingStartTime && startTime < existingEndTime) ||
                    (endTime > existingStartTime && endTime < existingEndTime) ||
                    (startTime > existingStartTime && endTime < existingEndTime))
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
            if(interaction=="update")
            {

                startTime = dtpTimeStart.Value;
                endTime = dtpTimeEnd.Value;
            }

            // Kiểm tra xem thời gian kết thúc có sau thời gian bắt đầu không
            if (endTime <= startTime)
            {
                MessageBox.Show("Thời gian kết thúc phải sau thời gian bắt đầu!");
                return;
            }



            //Cap nhat du lie ve len bang

            string sqlCalendar;
            if(EmployID.Contains("DE"))
            {
                sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Dentist WHERE DenID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
            }
            else if(EmployID.Contains("AS"))
            {
                sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Assisstant WHERE AssiID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
            }
            else
            {
                sqlCalendar = $"SELECT timeStart, timeEnd FROM Calendar_Receptionist WHERE RecepID = '{EmployID}' AND dayWorks = '{dtpDayWork.Value.Date}'";
            }

            DataTable tableCalendar = data.readData(sqlCalendar);
            if (IsEventTimeConflict(startTime, endTime, tableCalendar))
            {
                MessageBox.Show("Thời gian bị trùng với lịch làm việc đã có");
            }else
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
                    sqlAddCalendar = $"INSERT INTO Calendar_ReCeptionist(DenID, dayWorks, timeStart, timeEnd) VALUES ('{EmployID}', '{dtpDayWork.Value.Date}', '{startTime}', '{endTime}')";
                }
                data.changeData(sqlAddCalendar);
                MessageBox.Show("Đã lưu thành công! Vui lòng ấn nút tuần này để cập nhật dữ liệu");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new MainSchedule(EmployID, panelWrapper,role), panelWrapper);
        }
    }
}
