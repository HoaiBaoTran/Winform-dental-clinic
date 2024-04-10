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
                dataAppointDentist.ColumnCount = 6;
                dataAppointDentist.Columns[0].Name = "STT";
                dataAppointDentist.Columns[1].Name = "Giờ hẹn";
                dataAppointDentist.Columns[2].Name = "Phụ tá";
                dataAppointDentist.Columns[3].Name = "Bệnh nhân";
                dataAppointDentist.Columns[4].Name = "Triệu chứng bệnh nhân";
                dataAppointDentist.Columns[5].Name = "Trạng thái";
                int countRow = 1;
                bool flagApp = true;
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

                        string[] rowAppString = new string[] { countRow.ToString(), appTime, assisstantName, patientName,symptom, state };
                        dataAppointDentist.Rows.Add(rowAppString);
                        countRow++;
                        flagApp = false;
                    }
                }
                if(flagApp)
                {
                    MessageBox.Show("Nha sĩ không có lịch hẹn vào ngày này");
                }
            }
        }

        private void txtCurrDate_TextChanged(object sender, EventArgs e)
        {
            clearDataGridView(dataAppointDentist);
            initTableAppointment();
        }
    }
}
