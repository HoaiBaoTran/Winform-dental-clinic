using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI
{
    public partial class HistoryCheckUp : Form
    {
        DataInteraction data = new DataInteraction();
        DateTime currentDate = DateTime.Now;
        private Panel panelWrapper;
        private string patID;
        public HistoryCheckUp(Panel panelWrapper, string patID)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.patID = patID;
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

        private void HistoryCheckUp_Load(object sender, EventArgs e)
        {
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
                dtgv.AllowUserToAddRows = false;
            }
        }

        public void initTableAppointment()
        {
            btnToday.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            string sql = "select * from Appointment where patId = '" + patID + "'";
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataAppointPatient.ColumnCount = 6;
                dataAppointPatient.Columns[0].Name = "STT";
                dataAppointPatient.Columns[1].Name = "Giờ hẹn";
                dataAppointPatient.Columns[2].Name = "Phụ tá";
                dataAppointPatient.Columns[3].Name = "Nha sĩ";
                dataAppointPatient.Columns[4].Name = "Triệu chứng bệnh nhân";
                dataAppointPatient.Columns[5].Name = "Trạng thái";
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    // Cap nhat ma va ten bệnh nhân
                    if ((bool)row["able"] == true)
                    {
                        txtPatID.Text = (string)row["patID"];
                        string sqlPatient = "select * from Patient where patID = '" + patID + "'";
                        DataTable tablePatient = data.readData(sqlPatient);

                        if (tablePatient.Rows.Count > 0)
                        {
                            foreach (DataRow rowPat in tablePatient.Rows)
                            {
                                txtNamePat.Text = (string)rowPat["name"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại mã bênh nhân này");
                            return;
                        }
                    }

                    //Hien lich hen
                    if (DateTimeConvert.convertDMY(row["ap_time"].ToString()) == DateTimeConvert.convertDMY(currentDate.ToString()))
                    {
                        //Lay ten nha sĩ
                        string denID = row["denID"].ToString();
                        string sqlDentist = "select * from Dentist where denID = '" + denID + "'";
                        DataTable tableDentist = data.readData(sqlDentist);
                        string dentistName = "";
                        if (tableDentist.Rows.Count > 0)
                        {

                            foreach (DataRow rowDentist in tableDentist.Rows)
                            {
                                dentistName = (string)rowDentist["name"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tồn tại mã nha sĩ");
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

                        string[] rowAppString = new string[] { countRow.ToString(), appTime, assisstantName, dentistName, symptom, state };
                        dataAppointPatient.Rows.Add(rowAppString);
                        countRow++;
                    }
                }
            }
            //Căn giữa nội dung cột đầu tiên
            dataAppointPatient.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataAppointPatient.Columns[0].Width = 60;


            dataAppointPatient.EnableHeadersVisualStyles = false;
            dataAppointPatient.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void txtCurrDate_TextChanged(object sender, EventArgs e)
        {
            clearDataGridView(dataAppointPatient);
            initTableAppointment();
        }

        private void HistoryCheckUp_Resize(object sender, EventArgs e)
        {
            //Thay đổi kích thước các ô theo datagridview
            for (int i = 0; i < dataAppointPatient.ColumnCount; i++)
            {
                dataAppointPatient.Columns[i].Width = dataAppointPatient.Width / dataAppointPatient.ColumnCount;
            }
        }

        private void btnChooseDay_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            currentDate = calendarF.GetDateSelector();
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }
    }
}
