using N19_DentalClinic.DAO;
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

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class AddMaterial : Form
    {

        private DataInteraction data = new DataInteraction();
        private string materialIdInserted = string.Empty;

        private string oldMaterialId = string.Empty;
        private string oldMaterialName = string.Empty;
        private string oldType = string.Empty;
        private string oldQuantity = string.Empty;
        private string oldCalUnit = string.Empty;
        private string oldExpirationDate = string.Empty;

        private bool isEdit = false;
        public AddMaterial()
        {
            InitializeComponent();
        }

        public AddMaterial(string materialId, string materialName, string type, string quantity, string calUnit, string expirationDate)
        {
            InitializeComponent();
            this.oldMaterialId = materialId;
            this.oldMaterialName = materialName;
            this.oldType = type;
            this.oldQuantity = quantity;
            this.oldCalUnit = calUnit;
            this.oldExpirationDate = expirationDate;
            isEdit = true;
        }

        private string autoIncrementID()
        {
            string sql = @$"select top 1 materialID from material order by materialID desc";
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                oldMaterialId = (string)row["materialID"];
            }

            oldMaterialId = oldMaterialId.Substring(2, 8);
            int id = Convert.ToInt32(oldMaterialId);
            int newID = id + 1;
            string newIDString = Convert.ToString(newID);
            string temp = "MA00000000";
            string newServiceID = temp.Substring(0, 10 - newIDString.Length) + newIDString;
            return newServiceID;
        }

        private void handleAddMaterial()
        {
            string materialName = tbMaterialName.Text;
            string calUnit = tbCalUnit.Text;
            string type = cbType.Text;
            string functionType = cbFunction.Text;
            string expirationDate = dateTimePicker.Text;
            string time = DateTimeConvert.convertSqlTimeForDDMMYYYY(expirationDate);
            string quantity = tbQuantity.Text;
            string price = tbPrice.Text;

            if (materialName == string.Empty ||
                calUnit == string.Empty ||
                type == string.Empty ||
                functionType == string.Empty ||
                expirationDate == string.Empty ||
                time == string.Empty ||
                quantity == string.Empty ||
                price == string.Empty)
            {
                MessageBox.Show("Vui lòng điền hết thông tin");
                return;
            }

            if (!isEdit)
            {
                string newMaterialID = autoIncrementID();
                string sql = @$"insert into material(materialID, name, AdminID, CalUnit, quantity, able) values
                                ('{newMaterialID}', N'{materialName}', 'AD00000001', N'{calUnit}', " + quantity + ", 1)";
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
                string materialId = tbMaterialId.Text;
                string sql = string.Empty;
                if (type == "Tiêu hao")
                {
                    sql = "update Medicine set price = " + price + $" where materialId = '{materialId}'";

                    data.changeData(sql);

                    sql = @$"update ConsumableMaterial set
                                expiration_date = N'{time}', typeConMaterial = N'{functionType}' where materialId = '{materialId}'";

                    data.changeData(sql);
                }

                sql = @$"update Material set
                                name = N'{materialName}', CalUnit = N'{calUnit}', quantity = " + quantity + $" where materialId = '{materialId}'";

                data.changeData(sql);
                MessageBox.Show("Cập nhật vật liệu thành công");
                this.DialogResult = DialogResult.OK;
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
                btnAddMaterial.Text = "Cập nhật";

                tbMaterialId.Text = oldMaterialId;
                tbMaterialName.Text = oldMaterialName;
                tbQuantity.Text = oldQuantity;
                tbCalUnit.Text = oldCalUnit;
                cbType.Text = oldType;
                if (oldExpirationDate != string.Empty)
                {
                    DateTime date = DateTime.ParseExact(oldExpirationDate, "dd/MM/yyyy", null);
                    dateTimePicker.Value = date;
                }

                tbMaterialId.ReadOnly = true;
                cbType.Enabled = false;

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

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                tbPrice.Enabled = false;
                tbPrice.BackColor = Color.Gray;
                dateTimePicker.Enabled = false;
                dateTimePicker.CalendarMonthBackground = Color.Gray;
                dateTimePicker.CalendarTitleBackColor = Color.Gray;
            } else
            {
                tbPrice.Enabled = true;
                tbPrice.BackColor = Color.White;
                dateTimePicker.Enabled = true;
                dateTimePicker.CalendarMonthBackground = Color.White;
                dateTimePicker.CalendarTitleBackColor = Color.White;
            }
        }
    }
}
