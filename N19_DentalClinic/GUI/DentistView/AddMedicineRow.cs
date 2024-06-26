﻿using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.DentistView
{
    public partial class AddMedicineRow : Form
    {
        DataInteraction data = new DataInteraction();
        private string presId;

        private string medicineId = string.Empty;
        private string medicineName = string.Empty;
        private string quantity = string.Empty;
        private string calUnit = string.Empty;
        private string note = string.Empty;
        private bool isEdit = false;

        public AddMedicineRow(string presId)
        {
            InitializeComponent();
            this.presId = presId;
        }

        public AddMedicineRow(string presId, string medicineId, string medicineName, string quantity, string calUnit, string note)
        {
            InitializeComponent();
            this.presId = presId;
            this.medicineId = medicineId;
            this.medicineName = medicineName;
            this.quantity = quantity;
            this.calUnit = calUnit;
            this.note = note;
            isEdit = true;

            btnAddMedicine.Text = "Cập nhật";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMedicineRow_Load(object sender, EventArgs e)
        {
            comnboBoxMaterialLoad();
        }

        private void comnboBoxMaterialLoad()
        {
            string sql = @"select me.materialId, ma.name, ma.calUnit, ma.quantity 
                            from Medicine me
                            join Material ma on ma.materialID = me.materialID";
            DataTable table = data.readData(sql);
            cbMedicineId.DataSource = table;
            cbMedicineId.ValueMember = "materialId";

            cbMedicineName.DataSource = table;
            cbMedicineName.ValueMember = "name";

            cbCalUnit.DataSource = table;
            cbCalUnit.ValueMember = "calUnit";

            cbQuantity.DataSource = table;
            cbQuantity.ValueMember = "quantity";

            if (isEdit)
            {
                cbMedicineId.Text = medicineId;
                cbMedicineName.Text = medicineName;
                cbQuantity.Text = quantity;
                cbCalUnit.Text = calUnit;
                tbNote.Text = note;
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            handleAddMedicineRow();

        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            handleAddMedicineRow();
        }

        private void handleAddMedicineRow()
        {
            string medicineId = cbMedicineId.GetItemText(cbMedicineId.SelectedItem);
            string calUnit = cbCalUnit.GetItemText(cbCalUnit.SelectedItem);
            string quantity = cbQuantity.Text;
            string note = tbNote.Text;

            if (!isEdit)
            {
                string sql = @$"INSERT INTO Prescription_Detail(PresID, materialID, quantity, calUnit, note) values
                                ('{presId}', '{medicineId}', " + quantity + $", N'{calUnit}', N'{note}')";
                data.changeData(sql);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                string updateSql = @$"UPDATE Prescription_Detail SET
                                    materialID = '{medicineId}',
                                    quantity = " + quantity + @$",
                                    calUnit = '{calUnit}',
                                    note = '{note}'
                                    WHERE PresID = '{presId}' AND materialID = '{medicineId}'
                                    ";
                MessageBox.Show(updateSql);
                data.changeData(updateSql);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
