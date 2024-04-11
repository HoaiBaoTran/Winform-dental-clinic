using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N19_ProjectForm.DAO;

namespace N19_ProjectForm.GUI
{
    public partial class AppointmentForDentist : Form
    {
        DataInteraction data = new DataInteraction();
        DateTime currentDate = DateTime.Now;
        private Panel panelWrapper;
        private string sqlTime;
        private string DenID;
        public AppointmentForDentist(Panel panelWrapper, string denID)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            DenID = denID;
        }

        private void AppointmentForDentist_Load(object sender, EventArgs e)
        {
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
            string sql = @$"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, symptom, stateAp 
                        from Appointment a
                        join Patient p on p.PatID = a.PatID
                        join Dentist d on d.DenID = a.DenID
                        where datediff(day, ap_time, '{sqlTime}') = 0
                        ";
            updateDataGridView(sql);
        }

        public void updateDataGridView(string sql)
        {
            Dictionary<string, string> convertState = new Dictionary<string, string>();
            convertState.Add("A", "Bệnh nhân chưa đến");
            convertState.Add("B", "Bệnh nhân đã đến");
            convertState.Add("C", "Cuộc hẹn kết thúc");

            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataAppointmentDentist.ColumnCount = 6;
                dataAppointmentDentist.Columns[0].Name = "STT";
                dataAppointmentDentist.Columns[1].Name = "Mã lịch hẹn";
                dataAppointmentDentist.Columns[2].Name = "Tên nha sĩ";
                dataAppointmentDentist.Columns[3].Name = "Tên bệnh nhân";
                dataAppointmentDentist.Columns[4].Name = "Triệu chứng";
                dataAppointmentDentist.Columns[5].Name = "Tình trạng";
          
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] { 
                        countRow.ToString(), 
                        (string)row["ApID"], 
                        (string)row["patient_name"], 
                        (string)row["dentist_name"], 
                        (string)row["symptom"],
                        convertState[(string)row["stateAp"]]
                    };
                    dataAppointmentDentist.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataAppointmentDentist.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            currentDate = calendarF.GetDateSelector();
            sqlTime = DateTimeConvert.convertSqlTime(currentDate.ToString());
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
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
                dtgv.AllowUserToAddRows = true;
            }
        }

        public void initTableAppointment()
        {
            string sql = "select * from Appointment where DenId = '" + DenID + "'";
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataAppointmentDentist.ColumnCount = 6;
                dataAppointmentDentist.Columns[0].Name = "STT";
                dataAppointmentDentist.Columns[1].Name = "Giờ hẹn";
                dataAppointmentDentist.Columns[2].Name = "Phụ tá";
                dataAppointmentDentist.Columns[3].Name = "Bệnh nhân";
                dataAppointmentDentist.Columns[4].Name = "Triệu chứng bệnh nhân";
                dataAppointmentDentist.Columns[5].Name = "Trạng thái";
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    // Cap nhat ma va ten nha si
                    if ((bool)row["able"] == true)
                    {
                        txtDenID.Text = (string)row["denId"];
                        string sqlDentist = "select * from Dentist where denId = '" + DenID + "'";
                        DataTable tableDentist = data.readData(sqlDentist);

                        if (tableDentist.Rows.Count > 0)
                        {
                            foreach (DataRow rowDen in tableDentist.Rows)
                            {
                                txtNameDentist.Text = (string)rowDen["name"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại mã nha sĩ này");
                            return;
                        }
                    }

                    //Hien lich hen
                    if (DateTimeConvert.convertDMY(row["ap_time"].ToString()) == DateTimeConvert.convertDMY(currentDate.ToString()))
                    {
                        //Lay ten benh nhan
                        string patId = row["patId"].ToString();
                        string sqlPatient = "select * from Patient where patId = '" + patId + "'";
                        DataTable tablePatient = data.readData(sqlPatient);
                        string patientName = "";
                        if (tablePatient.Rows.Count > 0)
                        {

                            foreach (DataRow rowPatient in tablePatient.Rows)
                            {
                                patientName = (string)rowPatient["name"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại mã bệnh nhân");
                        }

                        string appTime = DateTimeConvert.convertHMS(row["ap_time"].ToString());
                        //Cap nhat them phu ta
                        string assisstantName = "";
                        string symptom = row["symptom"].ToString();
                        string state = "";
                        switch (row["stateAp"].ToString())
                        {
                            case "A":
                                state = "Bệnh nhân chưa đến";
                                break;
                            case "B":
                                state = "Bệnh nhân đã đến";
                                break;
                            case "C":
                                state = "Cuộc hẹn kết thúc";
                                break;
                        }

                        string[] rowAppString = new string[] { countRow.ToString(), appTime, assisstantName, patientName, symptom, state };
                        dataAppointmentDentist.Rows.Add(rowAppString);
                        countRow++;
                    }
                }
            }
        }

        private void txtCurrDate_TextChanged(object sender, EventArgs e)
        {
            clearDataGridView(dataAppointmentDentist);
            initTableAppointment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime yesterday = currentDate.Date.AddDays(-1);
            currentDate = yesterday;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tommorow = currentDate.Date.AddDays(+1);
            currentDate = tommorow;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
