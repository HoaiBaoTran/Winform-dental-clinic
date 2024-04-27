using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.DentistView;
using N19_DentalClinic.GUI.SupportView;
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
    public partial class AddBill : Form
    {
        private DataInteraction data = new DataInteraction();
        private bool isEdit = false; // chinh sua
        private string billId = "BI00000001";
        private string presId = "PR00000001";

        private int totalPrescriptionPrice = 0;
        private int totalServicePrice = 0;
        private int totalBillPrice = 0;

        private string patientId = string.Empty;
        private string dentistId = string.Empty;

        private bool isPrescriptionCreated = false;

        public AddBill(string bilId)
        {
            InitializeComponent();
            this.billId = bilId;
        }

        private void AddBill_Load(object sender, EventArgs e)
        {
            comboBoxLoad();
            if (!isEdit) //chinh sua 
            {
                tbBillId.Enabled = false;
                tbBillId.BackColor = Color.Gray;
            }
            else // them
            {
                dataPrescriptionLoad();
                dataServiceLoad();
            }

            dataPrescription.ColumnCount = 8;
            dataPrescription.Columns[0].Name = "STT";
            dataPrescription.Columns[1].Name = "Mã thuốc";
            dataPrescription.Columns[2].Name = "Tên thuốc";
            dataPrescription.Columns[3].Name = "Đơn vị";
            dataPrescription.Columns[4].Name = "Giá tiền";
            dataPrescription.Columns[5].Name = "Số lượng";
            dataPrescription.Columns[6].Name = "Tổng tiền";
            dataPrescription.Columns[7].Name = "Ghi chú";


            dataService.ColumnCount = 8;
            dataService.Columns[0].Name = "STT";
            dataService.Columns[1].Name = "Mã dịch vụ";
            dataService.Columns[2].Name = "Tên dịch vụ";
            dataService.Columns[3].Name = "Đơn vị";
            dataService.Columns[4].Name = "Giá tiền";
            dataService.Columns[5].Name = "Số lượng";
            dataService.Columns[6].Name = "Tổng tiền";
            dataService.Columns[7].Name = "Ghi chú";


            //Chinh default datagridview
            //Prescription
            dataPrescription.AllowUserToAddRows = false;
            dataPrescription.Columns[0].Width = 60;
            //Căn giữa nội dung cột đầu tiên
            dataPrescription.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataPrescription.EnableHeadersVisualStyles = false;
            dataPrescription.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");

            //Service
            dataService.AllowUserToAddRows = false;
            dataService.Columns[0].Width = 60;
            //Căn giữa nội dung cột đầu tiên
            dataPrescription.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataService.EnableHeadersVisualStyles = false;
            dataService.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void dataPrescriptionLoad()
        {
            dataPrescription.Rows.Clear();
            updateDataPrescriptionUiOnDataChange();
        }

        private void updateDataPrescriptionUiOnDataChange()
        {
            totalPrescriptionPrice = 0;
            string sql = @$"Select pd.materialID, ma.name, pd.quantity, ma.CalUnit, pd.note, me.price
                            from Prescription_Detail pd
                            join Material ma on ma.materialID = pd.materialID
                            join Medicine me on me.materialID = pd.materialID
                            where pd.PresID = '{presId}'";
            updateDataPrescriptionGridView(sql);
            totalBillPrice = totalPrescriptionPrice + totalServicePrice;
            lbPrice.Text = totalBillPrice.ToString("#,##0");
        }

        public void updateDataPrescriptionGridView(string sql)
        {
            dataPrescription.Rows.Clear();
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    int price = ((int)row["price"]);
                    int quantity = ((int)row["quantity"]);
                    int totalPrice = price * quantity;
                    totalPrescriptionPrice += totalPrice;
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["materialID"],
                        (string)row["name"],
                        (string)row["CalUnit"],
                        price.ToString("#,##0"),
                        quantity.ToString(),
                        totalPrice.ToString("#,##0"),
                        (string)row["note"]

                    };
                    dataPrescription.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataPrescription.AllowUserToAddRows = false;
        }

        private void dataServiceLoad()
        {
            dataService.Rows.Clear();
            updateDataServiceUiOnDataChange();
        }

        private void updateDataServiceUiOnDataChange()
        {
            totalServicePrice = 0;
            string sql = @$"select bs.bilID, bs.serviceID, bs.quantity, name as service_name, price as service_price, CalUnit, se.note
                            from Bill_Service bs
                            join Service se on bs.serviceID = se.serviceID
                            where bs.bilID = '{billId}'";
            updateDataServiceGridView(sql);
            totalBillPrice = totalPrescriptionPrice + totalServicePrice;
            lbPrice.Text = totalBillPrice.ToString("#,##0");
        }

        public void updateDataServiceGridView(string sql)
        {
            dataService.Rows.Clear();
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    int price = ((int)row["service_price"]);
                    int quantity = ((int)row["quantity"]);
                    int totalPrice = price * quantity;
                    totalServicePrice += totalPrice;
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["serviceID"],
                        (string)row["service_name"],
                        (string)row["CalUnit"],
                        price.ToString("#,##0"),
                        quantity.ToString(),
                        totalPrice.ToString("#,##0"),
                        (string)row["note"]
                    };
                    dataService.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataService.AllowUserToAddRows = false;
        }

        private void comboBoxLoad()
        {
            string sql = "Select PatId, name from Patient";
            DataTable table = data.readData(sql);

            cbPatientId.DataSource = table;
            cbPatientId.ValueMember = "PatId";

            cbPatientName.DataSource = table;
            cbPatientName.ValueMember = "name";


        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            handlebtnAddService();
        }

        private void roundPictureBox1_Click(object sender, EventArgs e)
        {
            handlebtnAddService();
        }

        private void handlebtnAddService()
        {
            AddServiceForBill addServiceForBill = new AddServiceForBill(billId);
            if (addServiceForBill.ShowDialog() == DialogResult.OK)
            {
                updateDataServiceUiOnDataChange();
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            handlebtnAddPrescription();
        }

        private void roundPictureBox4_Click(object sender, EventArgs e)
        {
            handlebtnAddPrescription();
        }

        private void handlebtnAddPrescription()
        {
            AddPrescriptionForBill addPrescriptionForBill = new AddPrescriptionForBill(presId);
            if (addPrescriptionForBill.ShowDialog() == DialogResult.OK)
            {
                updateDataPrescriptionUiOnDataChange();
            }
        }

        private void roundPictureBox5_Click(object sender, EventArgs e)
        {
            handlebtnCreatePrescription();
        }

        private void btnCreatePrescription_Click(object sender, EventArgs e)
        {
            handlebtnCreatePrescription();
        }

        private void handlebtnCreatePrescription()
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
                data.changeData(sqlUpdate);
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
                data.changeData(sqlInsert);
                string sqlSelect = @"SELECT TOP 1 presID FROM prescription ORDER BY presID DESC";
                DataTable table = data.readData(sqlSelect);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    presId = (string)row["presID"];
                    MessageBox.Show("Tạo đơn thuốc thành công");
                }

            }
            isPrescriptionCreated = !isPrescriptionCreated;
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            string totalPrice = lbPrice.Text.Replace(",", "");
            string patientId = cbPatientId.Text;
            string day = datePicker.Text;
            string time = timePicker.Text;
            string recepId = "RE00000001";
            string paymentTime = $"{DateTimeConvert.convertSqlTimeDay(day)} {DateTimeConvert.convertHMS(time)}";
            string sql = $"INSERT INTO Bill_Recep(RecepID, bilID) VALUES ('{recepId}', '{billId}')";
            data.changeData(sql);
            sql = "update Bill set total_price = " + totalPrice + $" , payment_time = '{paymentTime}' where bilID = '{billId}'";
            data.changeData(sql);
            MessageBox.Show("Thêm hóa đơn thành công");
            this.DialogResult = DialogResult.OK;
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {

            PatientFileCopy fileCopy = new PatientFileCopy();
            fileCopy.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
