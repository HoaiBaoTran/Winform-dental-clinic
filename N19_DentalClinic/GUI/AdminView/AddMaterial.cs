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

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class AddMaterial : Form
    {

        private DataInteraction data = new DataInteraction();
        private string materialIdInserted = string.Empty;
        private bool isEdit = false;
        public AddMaterial()
        {
            InitializeComponent();
        }

        private void handleAddMaterial()
        {
            string materialName = tbMaterialName.Text;
            string calUnit = tbCalUnit.Text;
            string type = cbType.Text;
            string functionType = cbFunction.Text;
            string expirationDate = dateTimePicker.Text;
            string quantity = tbQuantity.Text;
            string price = tbPrice.Text;

            if (!isEdit)
            {

                string sql = @$"insert into material(materialID, name, AdminID, CalUnit, quantity, able) values
                                (dbo.autoMaid(), N'{materialName}', 'AD00000001', N'{calUnit}', " + quantity + ", 1)";
                data.changeData(sql);

                string sqlSelect = @"SELECT TOP 1 materialID FROM material ORDER BY materialID DESC";
                DataTable table = data.readData(sqlSelect);
                if (table.Rows.Count > 0)
                {
                    DataRow row = table.Rows[0];
                    materialIdInserted = (string)row["materialID"];
                }

                if (type == "Cố định")
                {
                    string insertedFixedMaterialsql = @$"insert into FixedMaterial(materialID, able) values ('{materialIdInserted}', 1)";
                    data.changeData(insertedFixedMaterialsql);
                }
                else if (type == "Tiêu hao")
                {
                    string time = DateTimeConvert.convertSqlTimeForDDMMYYYY(expirationDate);

                    string insertedConsumableMaterialsql = @$"insert into ConsumableMaterial(materialID, expiration_date, typeConmaterial, able) values 
                                                        ('{materialIdInserted}', '{time}', N'{functionType}',1)";
     
                    data.changeData(insertedConsumableMaterialsql);

                    if (functionType == "Kháng sinh" || functionType == "Kháng viêm" || functionType == "Giảm đau")
                    {
                        string insertedMedicinesql = @$"insert into Medicine(materialID, price, able) values 
                                                            ('{materialIdInserted}', " + price + ", 1)";
                        data.changeData(insertedMedicinesql);
                    }
                }


                MessageBox.Show("Thêm vật liệu thành công");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                /*
                string sql = @$"update Service
                            set name = N'{serviceName}', price = " + price + $@", CalUnit = N'{calUnit}', quantity = 1, note = N'{note}'
                            where serviceID = '{serviceId}'";
                data.changeData(sql);
                MessageBox.Show("Cập nhật dịch vụ thành công");
                this.DialogResult = DialogResult.OK;
                */
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            handleAddMaterial();
        }

        private void AddMaterial_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {

            }
            else
            {
                tbMaterialId.Enabled = false;
                tbMaterialId.BackColor = Color.Gray;
                cbType.SelectedIndex = 0;
                cbFunction.SelectedIndex = 0;
            }
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            handleAddMaterial();
        }
    }
}
