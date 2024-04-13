using N19_DentalClinic.GUI.ReceptionistView;
using N19_ProjectForm.DAO;
using N19_ProjectForm.GUI.ReceptionistView;
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
    public partial class AssisstantFile : Form
    {
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        private int role;
        public AssisstantFile(Panel panelWrapper, int role)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
        }

        private void AssisstantFile_Load(object sender, EventArgs e)
        {
            string sql = "select * from assisstant where able = 1";
            updateDataGridView(sql);
        }

        public void clearDataGridView(DataGridView dtgv)
        {
            try
            {
                dtgv.Rows.Clear();
            }
            finally
            {
                dtgv.AllowUserToAddRows = true;
            }
        }

        public void updateDataGridView(string sql)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + "DBAF09");
            btnCreateDentist.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataAssisstantTable.ColumnCount = 11;
                dataAssisstantTable.Columns[0].Name = "STT";
                dataAssisstantTable.Columns[1].Name = "Mã phụ tá";
                dataAssisstantTable.Columns[2].Name = "Họ tên";
                dataAssisstantTable.Columns[3].Name = "Năm sinh";
                dataAssisstantTable.Columns[4].Name = "Địa chỉ";
                dataAssisstantTable.Columns[5].Name = "Số điện thoại";
                dataAssisstantTable.Columns[6].Name = "Email";
                dataAssisstantTable.Columns[7].Name = "Giới tính";
                dataAssisstantTable.Columns[8].Name = "Thông tin chi tiết";
                dataAssisstantTable.Columns[9].Name = "Chỉnh sửa";
                dataAssisstantTable.Columns[10].Name = "Xóa";
                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string gender = "";
                    if ((bool)row["gender"] == true)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nữ";
                    }
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["assiid"],
                        (string)row["name"],
                        DateTimeConvert.convertDMY(row["birthday"].ToString()),
                        (string)row["address"],
                        (string)row["phone_number"],
                        (string)row["email"],
                        gender,
                        "Thông tin chi tiết",
                        "Chỉnh sửa",
                        "Xóa"
                    };
                    dataAssisstantTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataAssisstantTable.AllowUserToAddRows = false;
            dataAssisstantTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataAssisstantTable.Columns[0].Width = 60;


            dataAssisstantTable.EnableHeadersVisualStyles = false;
            dataAssisstantTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from assisstant where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma phụ tá
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["assiid"].ToString() == txtSearch.Text)
                            {
                                string sqlFindByID = "select * from assisstant where able = 1 and assiid = '" + txtSearch.Text + "'";
                                clearDataGridView(dataAssisstantTable);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã phụ tá này");
                        }
                    }
                    break;
                // Tim theo ten phụ tá
                case 1:
                    string sqlFindByName = "select * from assisstant where able = 1 and name like N'%" + txtSearch.Text + "%'";
                    clearDataGridView(dataAssisstantTable);
                    updateDataGridView(sqlFindByName);
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                    break;
            }
        }

        private void btnCreateDentist_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                PanelInteraction.openForm(this, new AssisstantDescriptionDetail(panelWrapper, "", role, "create"), panelWrapper);
            }
            else
            {
                MessageBox.Show("Bạn không đủ ủy quyền để thêm phụ tá");
            }
        }

        private void dataAssisstantTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataAssisstantTable.CurrentCell == null) return;
            if (dataAssisstantTable.CurrentCell.ColumnIndex == 8)
            {
                string AssID = dataAssisstantTable[1, dataAssisstantTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new AssisstantDescriptionDetail(panelWrapper, AssID, role, "view"), panelWrapper);//sửa thông tin chi tiết phụ tá
            }
            else if(dataAssisstantTable.CurrentCell.ColumnIndex == 9)
            {
                if (role == 1)
                {
                    string AssID = dataAssisstantTable[1, dataAssisstantTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new AssisstantDescriptionDetail(panelWrapper, AssID, role, "update"), panelWrapper);//sửa thông tin chi tiết phụ tá
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để chỉnh sửa");
                }
            }
            else if (dataAssisstantTable.CurrentCell.ColumnIndex == 10)
            {
                if (role == 1)
                {
                    string AssID = dataAssisstantTable[1, dataAssisstantTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new DeleteAssisstant(panelWrapper, AssID, role, "delete"), panelWrapper);//Xóa thông tin chi tiết phụ tá
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
                }
            }
        }
    }
}
