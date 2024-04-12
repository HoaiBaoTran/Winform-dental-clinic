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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N19_DentalClinic.GUI.DentistView
{
    public partial class DentistPrescription : Form
    {

        Panel panel;
        DataInteraction data;
        private int role;

        private bool isPrescriptionCreated = false;
        private string presId = string.Empty;
        private string patientId = string.Empty;
        private string dentistId = string.Empty;

        DataInteraction dataInteraction = new DataInteraction();

        public DentistPrescription(Panel panel, int role)
        {
            InitializeComponent();
            data = new DataInteraction();
            this.panel = panel;
            this.role = role;
        }

        private void DentistPrescription_Load(object sender, EventArgs e)
        {
            dataPrescription.Rows.Clear();
            dataPrescription.ColumnCount = 6;
            dataPrescription.Columns[0].Name = "STT";
            dataPrescription.Columns[1].Name = "Mã thuốc";
            dataPrescription.Columns[2].Name = "Tên thuốc";
            dataPrescription.Columns[3].Name = "Số lượng";
            dataPrescription.Columns[4].Name = "Đơn vị";
            dataPrescription.Columns[5].Name = "Ghi chú";
            comboBoxPatientLoad();

            string sql = @$"Select pd.materialID, ma.name, pd.quantity, ma.CalUnit, pd.note
                            from Prescription_Detail pd
                            join Material ma
                            on ma.materialID = pd.materialID
                            where pd.PresID = '{presId}'";
            updateDataGridView(sql);

        }

        private void comboBoxPatientLoad()
        {
            string sql = @"select name, PatID from patient";
            DataTable table = data.readData(sql);
            cbPatientName.DataSource = table;
            cbPatientName.ValueMember = "name";

            cbPatientId.DataSource = table;
            cbPatientId.ValueMember = "PatID";
        }

        public void updateDataGridView(string sql)
        {
            dataPrescription.Rows.Clear();
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["materialID"],
                        (string)row["name"],
                        ((int)row["quantity"]).ToString(),
                        (string)row["CalUnit"],
                        (string)row["note"]
                    };
                    dataPrescription.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataPrescription.AllowUserToAddRows = false;
        }


        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            AddMedicineRow addMedicineRow = new AddMedicineRow(presId);
            if (addMedicineRow.ShowDialog() == DialogResult.OK)
            {
                string sql = @$"Select pd.materialID, ma.name, pd.quantity, ma.CalUnit, pd.note
                            from Prescription_Detail pd
                            join Material ma
                            on ma.materialID = pd.materialID
                            where pd.PresID = '{presId}'";
                updateDataGridView(sql);
            }
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {

            if (isPrescriptionCreated)
            {
                int totalPrice = 0;
                btnAddMedicine.Enabled = false;
                btnCreatePrescription.BackColor = ColorTranslator.FromHtml("#12DB4E");
                btnCreatePrescription.Text = "Tạo đơn thuốc";
                cbPatientId.Enabled = true;
                cbPatientName.Enabled = true;

                // Save Prescription
                string sqlSelect = @$"select PresId, quantity, price 
                                        from Prescription_Detail pd
                                        join Medicine me on me.materialID = pd.materialID
                                        where presId = '{presId}'";
                DataTable table = data.readData(sqlSelect);
                if (table.Rows.Count > 0)
                {

                    foreach (DataRow row in table.Rows)
                    {
                        int quantity = (int)row["quantity"];
                        int price = (int)row["price"];
                        totalPrice += (quantity * price);
                    }
                }

                string sqlUpdate = @$"update Prescription
                                    set totalPrice = " + totalPrice + $" where PresID = '{presId}'";
                dataInteraction.changeData(sqlUpdate);
                MessageBox.Show("Lưu đơn thuốc thành công");

            }
            else
            {
                btnAddMedicine.Enabled = true;
                btnCreatePrescription.BackColor = ColorTranslator.FromHtml("#DBAF09");
                btnCreatePrescription.Text = "Lưu";
                cbPatientId.Enabled = false;
                cbPatientName.Enabled = false;
                dataPrescription.Rows.Clear();

                patientId = cbPatientId.GetItemText(cbPatientId.SelectedItem);
                dentistId = "DE00000001";

                // Create Prescription
                string sqlInsert = @$"INSERT INTO Prescription(PresID, PatID, DenID,totalPrice) values 
                                      (dbo.autoPresid(), '{patientId}', '{dentistId}', 0)";
                dataInteraction.changeData(sqlInsert);
                string sqlSelect = @"SELECT TOP 1 presID FROM prescription ORDER BY presID DESC";
                DataTable table = dataInteraction.readData(sqlSelect);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    presId = (string)row["presID"];
                    MessageBox.Show("Tạo đơn thuốc thành công");
                }

            }
            isPrescriptionCreated = !isPrescriptionCreated;

        }

        private void dataPrescription_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataPrescription.Rows.Count > 0)
            {

                string medicineId = dataPrescription[1, dataPrescription.CurrentCell.RowIndex].Value.ToString();
                string medicineName = dataPrescription[2, dataPrescription.CurrentCell.RowIndex].Value.ToString();
                string quantity = dataPrescription[3, dataPrescription.CurrentCell.RowIndex].Value.ToString();
                string calUnit = dataPrescription[4, dataPrescription.CurrentCell.RowIndex].Value.ToString();
                string note = dataPrescription[5, dataPrescription.CurrentCell.RowIndex].Value.ToString();
                AddMedicineRow addMedicineRow = new AddMedicineRow(presId, medicineId, medicineName, quantity, calUnit, note);
                if (addMedicineRow.ShowDialog() == DialogResult.OK)
                {
                    string sql = @$"Select pd.materialID, ma.name, pd.quantity, ma.CalUnit, pd.note
                            from Prescription_Detail pd
                            join Material ma
                            on ma.materialID = pd.materialID
                            where pd.PresID = '{presId}'";
                    updateDataGridView(sql);
                }
            }
            /*
            else if (dataPatientTable.CurrentCell.ColumnIndex == 9) // Xem thong tin benh nhan
            {
                string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new PatientDecriptionDetail(panelWrapper, patId, 2, "view"), panelWrapper);
            }
            else if (dataPatientTable.CurrentCell.ColumnIndex == 10) // Sửa thong tin benh nhan
            {
                string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new PatientDecriptionDetail(panelWrapper, patId, 2, "update"), panelWrapper);
            }
            else if (dataPatientTable.CurrentCell.ColumnIndex == 11) // Xóa thong tin benh nhan
            {
                string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new DeletePatient(panelWrapper, patId, 2, "delete"), panelWrapper);
            }
            */
        }
    }
}
