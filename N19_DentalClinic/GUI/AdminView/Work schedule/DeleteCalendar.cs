using N19_DentalClinic.DAO;
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

namespace N19_DentalClinic.GUI.AdminView.Work_schedule
{
    public partial class DeleteCalendar : Form
    {
        DataInteraction data = new DataInteraction();
        private string EmployID;
        private int role;
        Panel panelWrapper;

        private string currday;
        private string startTime;
        private string endTime;
        public DeleteCalendar(string EmployID, int role, Panel panelWrapper,string currday, string startTime, string endTime)
        {
            InitializeComponent();
            this.EmployID = EmployID;
            this.role = role;
            this.panelWrapper = panelWrapper;
            this.currday = currday;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDelEmployee;
            if(EmployID.Contains("DE"))
            {
                sqlDelEmployee = @$"update calendar_dentist set able = 0
                    where denid = '{EmployID}' and
                          dayWorks = '{DateTimeConvert.convertSqlTimeDay(currday)}' and 
                          timeStart = '{startTime}' and
                          timeEnd = '{endTime}'";
            }else if(EmployID.Contains("AS"))
            {
                sqlDelEmployee = @$"update calendar_assisstant set able = 0
                    where assiid = '{EmployID}' and
                          dayWorks = '{DateTimeConvert.convertSqlTimeDay(currday)}' and
                          timeStart = '{startTime}' and
                          timeEnd = '{endTime}'";
            }
            else
            {
                sqlDelEmployee = @$"update calendar_receptionist set able = 0
                    where recepid = '{EmployID}' and
                          dayWorks = '{DateTimeConvert.convertSqlTimeDay(currday)}' and
                          timeStart = '{startTime}' and
                          timeEnd = '{endTime}'";
            }
            data.changeData(sqlDelEmployee);
            MessageBox.Show("Xóa lịch làm việc thành công");
            PanelInteraction.openForm(this, new ListCalendarOfDay(panelWrapper, EmployID, role), panelWrapper);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new ListCalendarOfDay(panelWrapper, EmployID, role), panelWrapper);
        }
    }
}
