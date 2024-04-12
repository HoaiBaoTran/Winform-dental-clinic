
using N19_DentalClinic.controller.receptionist;
using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class ManageAppointment : Form
    {
        Panel panel;
        DataInteraction data;
        public ManageAppointment(Panel panel)
        {
            InitializeComponent();
            data = new DataInteraction();
            this.panel = panel;
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            openAppointmentForm();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            openAppointmentForm();
        }

        private void openAppointmentForm()
        {
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.ShowDialog();
        }

        private void ManageAppointment_Load(object sender, EventArgs e)
        {
            string sql = @"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, a.able, symptom, stateAp 
                from Appointment a
                join Patient p on  a.PatID = p.PatId
                join Dentist d on d.DenID = a.DenID";
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
                dataAppointment.ColumnCount = 8;
                dataAppointment.Columns[0].Name = "STT";
                dataAppointment.Columns[1].Name = "Mã lịch hẹn";
                dataAppointment.Columns[2].Name = "Ngày hẹn";
                dataAppointment.Columns[3].Name = "Giờ hẹn";
                dataAppointment.Columns[4].Name = "Tên bệnh nhân";
                dataAppointment.Columns[5].Name = "Tên nha sĩ";
                dataAppointment.Columns[6].Name = "Trạng thái";
                dataAppointment.Columns[7].Name = "Ghi chú";
               
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] { 
                        countRow.ToString(), 
                        (string)row["ApID"],  
                        DateTimeConvert.convertDMY(row["ap_time"].ToString()),
                        DateTimeConvert.convertHMS(row["ap_time"].ToString()),
                        (string)row["patient_name"], 
                        (string)row["dentist_name"],
                        convertState[(string)row["stateAp"]],
                        ""
                    };
                    dataAppointment.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataAppointment.AllowUserToAddRows = false;
        }
    }
}
