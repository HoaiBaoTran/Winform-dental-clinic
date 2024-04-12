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

namespace N19_DentalClinic.GUI.DentistView
{
    public partial class DentistSchedule : Form
    {

        Panel panel;
        DataInteraction data;
        private int role;

        public DentistSchedule(Panel panel, int role)
        {
            InitializeComponent();
            data = new DataInteraction();
            this.panel = panel;
            this.role = role;
        }

        private void DentistSchedule_Load(object sender, EventArgs e)
        {
            string dentistID = "DE00000001";
            string sql = @$"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, symptom, stateAp 
                            from Appointment a
                            join Patient p on p.PatID = a.PatID
                            join Dentist d on d.DenID = a.DenID
                            Where a.DenID = '{dentistID}'";
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
                dataSchedule.ColumnCount = 7;
                dataSchedule.Columns[0].Name = "STT";
                dataSchedule.Columns[1].Name = "Mã lịch hẹn";
                dataSchedule.Columns[2].Name = "Ngày hẹn";
                dataSchedule.Columns[3].Name = "Giờ hẹn";
                dataSchedule.Columns[4].Name = "Tên bệnh nhân";
                dataSchedule.Columns[5].Name = "Trạng thái";
                dataSchedule.Columns[6].Name = "Ghi chú";

                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["ApID"],
                        DateTimeConvert.convertDMY(row["ap_time"].ToString()),
                        DateTimeConvert.convertHMS(row["ap_time"].ToString()),
                        (string)row["patient_name"],
                        convertState[(string)row["stateAp"]],
                        ""
                    };
                    dataSchedule.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataSchedule.AllowUserToAddRows = false;
        }
    }
}
