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
    public partial class DentistPrescription : Form
    {

        Panel panel;
        DataInteraction data;
        private int role;

        public DentistPrescription(Panel panel, int role)
        {
            InitializeComponent();
            data = new DataInteraction();
            this.panel = panel;
            this.role = role;
        }

        private void DentistPrescription_Load(object sender, EventArgs e)
        {

            dataPrescription.ColumnCount = 7;
            dataPrescription.Columns[0].Name = "STT";
            dataPrescription.Columns[1].Name = "Mã thuốc";
            dataPrescription.Columns[2].Name = "Tên thuốc";
            dataPrescription.Columns[3].Name = "Số lượng";
            dataPrescription.Columns[4].Name = "Đơn vị";
            dataPrescription.Columns[5].Name = "Ghi chú";

            /*
            string dentistID = "DE00000001";
            string sql = @$"select ApID, ap_time, p.name as patient_name, d.name as dentist_name, symptom, stateAp 
                            from Appointment a
                            join Patient p on p.PatID = a.PatID
                            join Dentist d on d.DenID = a.DenID
                            Where a.DenID = '{dentistID}'";
            updateDataGridView(sql);
            */
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
                    dataPrescription.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataPrescription.AllowUserToAddRows = false;
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineRow addMedicineRow = new AddMedicineRow();
            addMedicineRow.ShowDialog();
        }
    }
}
