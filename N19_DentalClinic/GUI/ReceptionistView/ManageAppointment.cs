
using N19_DentalClinic.controller.receptionist;
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

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class ManageAppointment : Form
    {
        private string ApId;
        DataInteraction data;
        private int role;
        DateTime currentDate = DateTime.Now;
        public ManageAppointment(int role)
        {
            InitializeComponent();
            this.role = role;
            data = new DataInteraction();
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            openAppointmentForm("create", "");
        }

        private void openAppointmentForm(string interaction, string ApId)
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm(interaction, ApId);
            addAppointmentForm.ShowDialog();
        }

        private void ManageAppointment_Load(object sender, EventArgs e)
        {
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

        public void updateDataGridView()
        {
            btnToday.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            btnCreateAppointment.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            string sql = $@"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, a.able, symptom, stateAp
                from Appointment a
                join Patient p on  a.PatID = p.PatId
                join Dentist d on d.DenID = a.DenID
                where a.able = 1 ";
            Dictionary<string, string> convertState = new Dictionary<string, string>();
            convertState.Add("A", "Bệnh nhân chưa đến");
            convertState.Add("B", "Bệnh nhân đã đến");
            convertState.Add("C", "Cuộc hẹn kết thúc");

            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataAppointmentTable.ColumnCount = 11;
                dataAppointmentTable.Columns[0].Name = "STT";
                dataAppointmentTable.Columns[1].Name = "Mã lịch hẹn";
                dataAppointmentTable.Columns[2].Name = "Ngày hẹn";
                dataAppointmentTable.Columns[3].Name = "Giờ hẹn";
                dataAppointmentTable.Columns[4].Name = "Tên bệnh nhân";
                dataAppointmentTable.Columns[5].Name = "Tên nha sĩ";
                dataAppointmentTable.Columns[6].Name = "Trạng thái";
                dataAppointmentTable.Columns[7].Name = "Ghi chú";
                dataAppointmentTable.Columns[8].Name = "Chỉnh sửa";
                dataAppointmentTable.Columns[9].Name = "Xóa";
                dataAppointmentTable.Columns[10].Name = "Xem";

                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    if (DateTimeConvert.convertDMY(row["ap_time"].ToString()) == DateTimeConvert.convertDMY(currentDate.ToString()))
                    {
                        string[] rowString = new string[] {
                            countRow.ToString(),
                            (string)row["ApID"],
                            DateTimeConvert.convertDMY(row["ap_time"].ToString()),
                            DateTimeConvert.convertHMS(row["ap_time"].ToString()),
                            (string)row["patient_name"],
                            (string)row["dentist_name"],
                            convertState[(string)row["stateAp"]],
                            "",
                            "Chỉnh sửa",
                            "Xóa",
                            "Xem"
                        };
                        dataAppointmentTable.Rows.Add(rowString);
                        countRow++;
                    }
                }
            }
            dataAppointmentTable.AllowUserToAddRows = false;
            dataAppointmentTable.Columns[0].Width = 60;


            dataAppointmentTable.EnableHeadersVisualStyles = false;
            dataAppointmentTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }


        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            if (role == 3)
            {
                MessageBox.Show("Bạn không đủ ủy quyền");
            }
            else
            {
                openAppointmentForm("create", "");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            currentDate = calendarF.GetDateSelector();
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

        private void btnToday_Click(object sender, EventArgs e)
        {
            currentDate = DateTime.Now;
            txtCurrDate.Text = DateTimeConvert.convertDMY(currentDate.ToString());
        }

        private void txtCurrDate_TextChanged(object sender, EventArgs e)
        {
            clearDataGridView(dataAppointmentTable);
            string sql = $@"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, a.able, symptom, stateAp
                from Appointment a
                join Patient p on  a.PatID = p.PatId
                join Dentist d on d.DenID = a.DenID
                where a.able = 1 ";
            updateDataGridView();
        }

        private void dataAppointmentTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataAppointmentTable.CurrentCell == null) return;
            if (dataAppointmentTable.CurrentCell.ColumnIndex == 8)
            {
                if (role < 3)
                {
                    ApId = dataAppointmentTable[1, dataAppointmentTable.CurrentCell.RowIndex].Value.ToString();
                    openAppointmentForm("update", ApId);
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thầm quyền để chỉnh sửa");
                }
            }
            else if (dataAppointmentTable.CurrentCell.ColumnIndex == 9)
            {
                if (role < 3)
                {
                    ApId = dataAppointmentTable[1, dataAppointmentTable.CurrentCell.RowIndex].Value.ToString();
                    DeleteAppointment delAp = new DeleteAppointment(ApId);
                    delAp.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thầm quyền để xóa");
                }

            }
            else if (dataAppointmentTable.CurrentCell.ColumnIndex == 10)
            {
                ApId = dataAppointmentTable[1, dataAppointmentTable.CurrentCell.RowIndex].Value.ToString();
                openAppointmentForm("view", ApId);
                //Form delete

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearDataGridView(dataAppointmentTable);
            string sql = $@"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, a.able, symptom, stateAp
                from Appointment a
                join Patient p on  a.PatID = p.PatId
                join Dentist d on d.DenID = a.DenID
                where a.able = 1 ";
            updateDataGridView();
        }
    }
}
