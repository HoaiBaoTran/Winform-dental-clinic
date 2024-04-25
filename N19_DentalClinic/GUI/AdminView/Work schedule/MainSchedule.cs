using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.AdminView;
using N19_DentalClinic.GUI.ReceptionistView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.Work_schedule
{
    public partial class MainSchedule : Form
    {
        private string EmployID;
        public static int static_month, static_year;
        private int month, year, week;
        private DateTime currentWeekStart;
        DateTime now = DateTime.Now;
        Panel panelWrapper;
        private int role;
        DataInteraction data = new DataInteraction();

        public MainSchedule(string EmployID, Panel panelWrapper, int role)
        {
            InitializeComponent();
            this.EmployID = EmployID;
            this.panelWrapper = panelWrapper;
            this.role = role;
        }


        private void MainSchedule_Load_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            currentWeekStart = StartOfWeek(now, DayOfWeek.Monday);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);
            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);
            string sqlGetName = "";
            if (EmployID.Contains("AS"))
            {
                sqlGetName = "select name from assisstant where able = 1 and assiID = '" + EmployID + "'";
            }
            else if (EmployID.Contains("DE"))
            {
                sqlGetName = "select name from dentist where able = 1 and denID = '" + EmployID + "'";
            }
            else
            {
                sqlGetName = "select name from receptionist where able = 1 and recepID = '" + EmployID + "'";
            }
            DataTable tableGetName = data.readData(sqlGetName);
            if (tableGetName.Rows.Count > 0)
            {
                foreach (DataRow row in tableGetName.Rows)
                {
                    txtName.Text = row["name"].ToString();
                    break;
                }
            }
        }

        //Lấy ngày đầu tuần
        private static DateTime StartOfWeek(DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }

        //Lấy ngày cuối tuần 
        private DateTime GetEndOfWeek(DateTime startOfWeek)
        {
            DateTime endOfWeek = startOfWeek.AddDays(6);
            endOfWeek = endOfWeek.Date.AddDays(1).AddSeconds(-1);
            return endOfWeek;
        }

        //Hiển thị từng ngày trong tuần
        private void DisplayDays(DateTime currentWeekStart)
        {

            daycontainer.Controls.Clear();
            month = DateTime.Now.Month;
            year = DateTime.Now.Year;

            static_month = month;
            static_year = year;

            for (int i = 0; i < 7; i++)
            {
                UserControlDay ucdays = new UserControlDay(EmployID);
                if (i == 6)
                {
                    ucdays.ForeColor = Color.Red;
                }
                daycontainer.Controls.Add(ucdays);
                ucdays.DisplayEvent(currentWeekStart.AddDays(i));
            }
        }

        //Chuyển qua tuần tiếp theo
        private void btpNext_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(+7);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);

            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);
        }

        //Lùi lại tuần sau
        private void ptbPrevious_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(-7);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);

            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);


        }

        //Quay trở lại tuần hiện tại
        private void nowWeek_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            currentWeekStart = StartOfWeek(now, DayOfWeek.Monday);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);
            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);
        }

        //Thêm lịch làm việc mới 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCalendarToEmployee addEvent = new AddCalendarToEmployee(EmployID, panelWrapper, role, "create", "", "", ""); // Tao moi thi thoi gian de trong 
            addEvent.Show();
        }


        private void btnYesterday_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(-7);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);

            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);
        }

        private void btnTommorow_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(+7);
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);
            dateFrom.Value = currentWeekStart;
            dateTo.Value = endOfWeek;
            DisplayDays(currentWeekStart);
        }

        private void dateFrom_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateFrom.Value.Date;
            DateTime startOfWeek = StartOfWeek(selectedDate, DayOfWeek.Monday);
            dateFrom.Value = startOfWeek;
        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTo.Value.Date;
            DateTime endOfWeek = GetEndOfWeek(currentWeekStart);
            dateTo.Value = endOfWeek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new ListCalendarOfDay(panelWrapper, EmployID, role), panelWrapper);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (EmployID.Contains("AS"))
            {
                PanelInteraction.openForm(this, new AssisstantDescriptionDetail(panelWrapper, EmployID, role,"view"), panelWrapper);

            }
            else if (EmployID.Contains("DE"))
            {
                PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, EmployID, role, "view"), panelWrapper);

            }
            else
            {
                PanelInteraction.openForm(this, new ReceptionDescriptionDetail(panelWrapper, EmployID, role, "view"), panelWrapper);

            }
        }
    }
}
