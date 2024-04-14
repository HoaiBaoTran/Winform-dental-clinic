using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.AdminView.Work_schedule;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.GUI.Work_schedule;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class ListCalendarOfDay : Form
    {
        DataInteraction data = new DataInteraction();
        DateTime currentDate = DateTime.Now;
        private Panel panelWrapper;
        private string interaction;
        private int role;
        private string EmployID;
        public ListCalendarOfDay(Panel panelWrapper, string EmployID, int role)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
            this.EmployID = EmployID;
            
        }

        private void ListCalendarOfDay_Load(object sender, EventArgs e)
        {
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            currentDate = calendarF.GetDateSelector();
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            DateTime yesterday = currentDate.Date.AddDays(-1);
            currentDate = yesterday;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void btnTommorow_Click(object sender, EventArgs e)
        {
            DateTime tommorow = currentDate.Date.AddDays(+1);
            currentDate = tommorow;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        public void clearDataGridView(DataGridView dtgv)
        {
            try
            {
                dtgv.Rows.Clear();
            }
            finally
            {
                dtgv.AllowUserToAddRows = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new MainSchedule(EmployID, panelWrapper, role), panelWrapper);
        }

        private void txtCurrDate_TextChanged(object sender, EventArgs e)
        {
            clearDataGridView(dataCalendarEmployee);
            initTableAppointment();
        }

        private void initTableAppointment()
        {
            string dataFindName;
            if (EmployID.Contains("DE"))
            {
                dataFindName = $@"select name from Dentist WHERE DenID = '{EmployID}'";
            }
            else if (EmployID.Contains("AS"))
            {
                dataFindName = $@"select name from Assisstant WHERE assiid = '{EmployID}'";
            }
            else
            {
                dataFindName = $@"select name from Receptionist WHERE recepid = '{EmployID}'";
            }
            DataTable tableFindName = data.readData(dataFindName);
            if (tableFindName.Rows.Count > 0)
            {
                foreach (DataRow row in tableFindName.Rows)
                {
                    txtNameEmploy.Text = row["name"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại mã nhân sự này");
            }
            txtEmplyID.Text = EmployID;

            string sqlCalendarOfEmployee;
            if (EmployID.Contains("DE"))
            {
                sqlCalendarOfEmployee = $@"select * from Calendar_Dentist WHERE DenID = '{EmployID}'";
            }
            else if (EmployID.Contains("AS"))
            {
                sqlCalendarOfEmployee = $@"select * from Calendar_Assisstant WHERE assiid = '{EmployID}'";
            }
            else
            {
                sqlCalendarOfEmployee = $@"select * from Calendar_Receptionist WHERE recepid = '{EmployID}'";
            }
            DataTable tableCalendar = data.readData(sqlCalendarOfEmployee);
            dataCalendarEmployee.ColumnCount = 6;
            dataCalendarEmployee.Columns[0].Name = "STT";
            dataCalendarEmployee.Columns[1].Name = "Mã nhân sự";
            dataCalendarEmployee.Columns[2].Name = "Giờ bắt đầu";
            dataCalendarEmployee.Columns[3].Name = "Giờ kết thúc";
            dataCalendarEmployee.Columns[4].Name = "Chỉnh sửa";
            dataCalendarEmployee.Columns[5].Name = "Xóa";
            int countRow = 1;
            if (tableCalendar.Columns.Count > 0)
            {
                foreach (DataRow dr in tableCalendar.Rows)
                {
                    string EmID;
                    if (EmployID.Contains("DE"))
                    {
                        EmID = dr["denid"].ToString();
                    }
                    else if (EmployID.Contains("AS"))
                    {
                        EmID = dr["assiid"].ToString();
                    }
                    else
                    {
                        EmID = dr["recepid"].ToString();
                    }
                    string currday = DateTimeConvert.convertDMY(currentDate.ToString());
                    string startTime = DateTimeConvert.convertHMS(dr["timeStart"].ToString());
                    string endTime = DateTimeConvert.convertHMS(dr["timeEnd"].ToString());
                    string[] rowString = new string[]
                    {
                        countRow.ToString(),
                        currday.ToString(),
                        startTime.ToString(),
                        endTime.ToString(),
                        "Chỉnh sửa",
                        "Xóa"
                    };
                    dataCalendarEmployee.Rows.Add(rowString);
                    countRow++;
                }
            }

            dataCalendarEmployee.AllowUserToAddRows = false;
            dataCalendarEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataCalendarEmployee.Columns[0].Width = 60;


            dataCalendarEmployee.EnableHeadersVisualStyles = false;
            dataCalendarEmployee.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");

        }

        private void dataCalendarEmployee_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataCalendarEmployee.CurrentCell == null) return;
            if (dataCalendarEmployee.CurrentCell.ColumnIndex == 4)
            {
                string CurrId = dataCalendarEmployee[1, dataCalendarEmployee.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new AddCalendarToEmployee(CurrId , panelWrapper, role, "update"), panelWrapper);//Chỉnh sửa
            }
            else if (dataCalendarEmployee.CurrentCell.ColumnIndex == 5)
            {
                string CurrId = dataCalendarEmployee[1, dataCalendarEmployee.CurrentCell.RowIndex].Value.ToString();
                string currday = txtCurrDate.ToString();
                string startT = dataCalendarEmployee[2, dataCalendarEmployee.CurrentCell.RowIndex].Value.ToString();
                string endT = dataCalendarEmployee[3, dataCalendarEmployee.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new DeleteCalendar(CurrId, role, panelWrapper, currday,startT,endT), panelWrapper);//Xóa
            }
        }
    }
}
