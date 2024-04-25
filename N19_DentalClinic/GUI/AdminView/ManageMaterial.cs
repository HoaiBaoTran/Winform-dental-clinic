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
    public partial class ManageMaterial : Form
    {

        private int role;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();

        public ManageMaterial(Panel panel, int role)
        {
            InitializeComponent();
            panelWrapper = panel;
            this.role = role;
        }

        private void ManageMaterial_Load(object sender, EventArgs e)
        {
            updateUiOnDataChange();
        }

        public int updateDataGridView(string sql, string type, bool expirationDate, int startRow, string price)
        {
            DataTable table = data.readData(sql);
            int countRow = startRow;
            if (table.Rows.Count > 0)
            {
                dataMaterial.ColumnCount = 10;
                dataMaterial.Columns[0].Name = "STT";
                dataMaterial.Columns[1].Name = "Mã vật liệu";
                dataMaterial.Columns[2].Name = "Tên vật liệu";
                dataMaterial.Columns[3].Name = "Loại vật liệu";
                dataMaterial.Columns[4].Name = "Số lượng";
                dataMaterial.Columns[5].Name = "Đơn vị tính";
                dataMaterial.Columns[6].Name = "Ngày hết hạn";
                dataMaterial.Columns[7].Name = "Giá tiền";
                dataMaterial.Columns[8].Name = "Chỉnh sửa";
                dataMaterial.Columns[9].Name = "Xóa";
                dataMaterial.EnableHeadersVisualStyles = false;
                dataMaterial.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
                dataMaterial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                foreach (DataRow row in table.Rows)
                {
                    string expiration = string.Empty;
                    if (expirationDate)
                    {
                        expiration = DateTimeConvert.convertDMY(row["expiration_date"].ToString());
                        if(row.Table.Columns.Contains("price"))
                        {
                            price = row["price"].ToString();
                        }
                    }
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["materialID"],
                        (string)row["name"],
                        type,
                        ((int)row["quantity"]).ToString(),
                        (string)row["calUnit"],
                        expiration,
                        price,
                        "Chỉnh sửa",
                        "Xóa" };
                    dataMaterial.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataMaterial.AllowUserToAddRows = false;

            //Căn giữa nội dung cột đầu tiên
            dataMaterial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataMaterial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            return countRow;
        }

        private void updateUiOnDataChange()
        {

            dataMaterial.Rows.Clear();
            string fixedMaterialsql = @"select fm.materialID, name, quantity, CalUnit 
                            from FixedMaterial fm
                            join Material ma on ma.materialID = fm.materialID";
            int startRow = updateDataGridView(fixedMaterialsql, "Cố định", false, 1, "");
            string consumablesql = @"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial
                                    from Material ma
                                    join ConsumableMaterial cm on ma.materialID = cm.materialID
                                    where cm.materialID not in (select materialID from medicine)";
            int nextRow = updateDataGridView(consumablesql, "Tiêu hao", true, startRow++,"");
            string medicinesql = @"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial, me.price
                                    from Material ma
                                    join ConsumableMaterial cm on ma.materialID = cm.materialID
                                    join medicine me on me.materialID = cm.materialID";
            updateDataGridView(medicinesql, "Tiêu hao", true, nextRow++, "");

        }

        private void findFixedMaterial()
        {
            dataMaterial.Rows.Clear();
            string fixedMaterialsql = @"select fm.materialID, name, quantity, CalUnit 
                            from FixedMaterial fm
                            join Material ma on ma.materialID = fm.materialID";
            updateDataGridView(fixedMaterialsql, "Cố định", false, 1, "");
        }

        private void findConsumableMaterial()
        {
            dataMaterial.Rows.Clear();
            string consumablesql = @"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial
                                    from Material ma
                                    join ConsumableMaterial cm on ma.materialID = cm.materialID";
            int nextRow = updateDataGridView(consumablesql, "Tiêu hao", true, 1, "");
            string medicinesql = @"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial, me.price
                                    from Material ma
                                    join ConsumableMaterial cm on ma.materialID = cm.materialID
                                    join medicine me on me.materialID = cm.materialID";
            updateDataGridView(medicinesql, "Tiêu hao", true, nextRow++, "");
        }

        private void btnFixedMaterial_Click(object sender, EventArgs e)
        {
            findFixedMaterial();
        }

        private void btnConsumableMaterial_Click(object sender, EventArgs e)
        {
            findConsumableMaterial();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //string materialIDSearch = tbSearch.Text;
            //if (materialIDSearch != string.Empty)
            //{
            //    dataMaterial.Rows.Clear();
            //    string fixedMaterialsql = @$"select fm.materialID, name, quantity, CalUnit 
            //                    from FixedMaterial fm
            //                    join Material ma on ma.materialID = fm.materialID
            //                    where fm.materialID = '{materialIDSearch}'";
            //    DataTable table = data.readData(fixedMaterialsql);
            //    if (table.Rows.Count > 0)
            //    {
            //        updateDataGridView(fixedMaterialsql, "Cố định", false, 1);
            //        return;
            //    }
            //    else
            //    {
            //        string consumablesql = @$"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial
            //                                from Material ma
            //                                join ConsumableMaterial cm on ma.materialID = cm.materialID
            //                                where ma.materialID = '{materialIDSearch}'";
            //        table = data.readData(consumablesql);
            //        if (table.Rows.Count > 0)
            //        {
            //            updateDataGridView(consumablesql, "Tiêu hao", true, 1);
            //        }
            //        else
            //        {
            //            MessageBox.Show("Id không tồn tại");
            //            return;
            //        }
            //    }

            //}
            //else
            //{
            //    updateUiOnDataChange();
            //}

            string sql = "select * from material where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma vat lieu
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["materialID"].ToString() == tbSearch.Text)
                            {
                                string sqlFindByID = "select * from material where able = 1 and materialID = '" + tbSearch.Text + "'";
                                dataMaterial.Rows.Clear();
                                updateDataGridView(sqlFindByID, "");
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã vật liệu này");
                        }
                    }
                    break;
                // Tim theo ten vat lieu
                case 1:
                    string sqlFindByName = "select * from material where able = 1 and name like N'%" + tbSearch.Text + "%'";
                    dataMaterial.Rows.Clear();
                    updateDataGridView(sqlFindByName,"");
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                    break;
            }
        }

        private void btnAddMaterial_Click(object sender, EventArgs e)
        {
            AddMaterial addMaterial = new AddMaterial();
            if (addMaterial.ShowDialog() == DialogResult.OK)
            {
                updateUiOnDataChange();
            }
        }

        private void dataMaterial_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataMaterial.Rows.Count > 0)
            {
                if (dataMaterial.CurrentCell.ColumnIndex == 9)
                {
                    string materialId = dataMaterial[1, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string materialName = dataMaterial[2, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string type = dataMaterial[3, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string title = "Xác nhận xóa";
                    string message = $"Bạn có chắc muốn xóa {materialName} với id là {materialId}???";
                    var confirmResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        if (type == "Cố định")
                        {
                            string sql = @$"delete from FixedMaterial 
                                            where materialId = '{materialId}'";
                            data.changeData(sql);
                            sql = @$"delete from Material 
                                            where materialId = '{materialId}'";
                            data.changeData(sql);
                        }
                        else
                        {
                            string sql = @$"delete from Medicine 
                                            where materialId = '{materialId}'";
                            data.changeData(sql);
                            sql = @$"delete from ConsumableMaterial 
                                            where materialId = '{materialId}'";
                            data.changeData(sql);
                            sql = @$"delete from Material 
                                            where materialId = '{materialId}'";
                            data.changeData(sql);
                        }
                        MessageBox.Show("Xóa thành công");
                        updateUiOnDataChange();
                    }
                }
                else if (dataMaterial.CurrentCell.ColumnIndex == 8)
                {
                    string materialId = dataMaterial[1, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string materialName = dataMaterial[2, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string type = dataMaterial[3, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string quantity = dataMaterial[4, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string calUnit = dataMaterial[5, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    string expirationDate = dataMaterial[6, dataMaterial.CurrentCell.RowIndex].Value.ToString();
                    AddMaterial addMaterial = new AddMaterial(materialId, materialName, type, quantity, calUnit, expirationDate);
                    if (addMaterial.ShowDialog() == DialogResult.OK)
                    {
                        updateUiOnDataChange();
                    }
                }

            }
        }

        //update theo loai va ma khong phan biet loai vat lieu
        public void updateDataGridView(string sql, string price)
        {
            DataTable table = data.readData(sql);
            int countRow = 1;
            if (table.Rows.Count > 0)
            {
                dataMaterial.ColumnCount = 10;
                dataMaterial.Columns[0].Name = "STT";
                dataMaterial.Columns[1].Name = "Mã vật liệu";
                dataMaterial.Columns[2].Name = "Tên vật liệu";
                dataMaterial.Columns[3].Name = "Loại vật liệu";
                dataMaterial.Columns[4].Name = "Số lượng";
                dataMaterial.Columns[5].Name = "Đơn vị tính";
                dataMaterial.Columns[6].Name = "Ngày hết hạn";
                dataMaterial.Columns[7].Name = "Gíá tiền";
                dataMaterial.Columns[8].Name = "Chỉnh sửa";
                dataMaterial.Columns[9].Name = "Xóa";
                dataMaterial.EnableHeadersVisualStyles = false;
                dataMaterial.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
                dataMaterial.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                foreach (DataRow row in table.Rows)
                {
                    string expiration = string.Empty;
                    string sqlCheckIsConsumed = "select expiration_date from ConsumableMaterial where able = 1 and materialid  = '" + row["materialId"].ToString() + "'";
                    DataTable tableIsComsumed = data.readData(sqlCheckIsConsumed);
                    //La vat lieu tieu hao
                    if (tableIsComsumed.Rows.Count > 0)
                    {
                        foreach (DataRow rowComsum in tableIsComsumed.Rows)
                        {
                            string sqlMedicine = "select price from medicine where materialid = '" + row["materialId"].ToString() + "'";
                            DataTable tableMedicine = data.readData(sqlMedicine);
                            if(tableMedicine.Rows.Count > 0)
                            {
                                foreach(DataRow rowMedicine in  tableMedicine.Rows)
                                {
                                    price = rowMedicine["price"].ToString();
                                }
                            }
                            expiration = DateTimeConvert.convertDMY(rowComsum["expiration_date"].ToString());
                            string[] rowString = new string[] {
                                countRow.ToString(),
                                (string)row["materialID"],
                                (string)row["name"],
                                "Tiêu hao",
                                ((int)row["quantity"]).ToString(),
                                (string)row["calUnit"],
                                expiration,
                                price,
                                "Chỉnh sửa",
                                "Xóa" };
                            dataMaterial.Rows.Add(rowString);
                            countRow++;
                        }
                    }
                    else
                    //La vat lieu co dinh
                    {
                        string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["materialID"],
                        (string)row["name"],
                        "Cố định",
                        ((int)row["quantity"]).ToString(),
                        (string)row["calUnit"],
                        expiration,
                        price,
                        "Chỉnh sửa",
                        "Xóa" };
                        dataMaterial.Rows.Add(rowString);
                        countRow++;
                    }
                }
            }
            dataMaterial.AllowUserToAddRows = false;

            //Căn giữa nội dung cột đầu tiên
            dataMaterial.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataMaterial.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void btnMedicine_Click(object sender, EventArgs e)
        {
            dataMaterial.Rows.Clear();
            string medicineSql = @"select cm.materialID, name, quantity, CalUnit, expiration_date, typeConMaterial, me.price
                                    from Material ma
                                    join ConsumableMaterial cm on ma.materialID = cm.materialID 
                                    join Medicine me on me.materialID = cm.materialid";
            updateDataGridView(medicineSql, "Tiêu hao", true, 1, "");
        }

    }
}
