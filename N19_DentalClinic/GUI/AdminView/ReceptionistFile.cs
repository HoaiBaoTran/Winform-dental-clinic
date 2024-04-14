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
    public partial class ReceptionistFile : Form
    {
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        private int role;
        public ReceptionistFile(Panel panelWrapper, int role)
        {
            InitializeComponent();
            this.role = role;
            this.panelWrapper = panelWrapper;
        }

        private void ReceptionistFile_Load(object sender, EventArgs e)
        {
            string sql = "select * from receptionist where able = 1";
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
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + "DBf09");
            btnCreateReptionist.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataReceptionistTable.ColumnCount = 11;
                dataReceptionistTable.Columns[0].Name = "STT";
                dataReceptionistTable.Columns[1].Name = "Mã lễ tân";
                dataReceptionistTable.Columns[2].Name = "Họ tên";
                dataReceptionistTable.Columns[3].Name = "Năm sinh";
                dataReceptionistTable.Columns[4].Name = "Địa chỉ";
                dataReceptionistTable.Columns[5].Name = "Số điện thoại";
                dataReceptionistTable.Columns[6].Name = "Email";
                dataReceptionistTable.Columns[7].Name = "Giới tính";
                dataReceptionistTable.Columns[8].Name = "Thông tin chi tiết";
                dataReceptionistTable.Columns[9].Name = "Chỉnh sửa";
                dataReceptionistTable.Columns[10].Name = "Xóa";
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
                        (string)row["recepid"],
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
                    dataReceptionistTable.Rows.Add(rowString);
                    countRow++;
                }
            }

            //Header row datagridview
            dataReceptionistTable.AllowUserToAddRows = false;
            dataReceptionistTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataReceptionistTable.Columns[0].Width = 60;

            dataReceptionistTable.EnableHeadersVisualStyles = false;
            dataReceptionistTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E"); ;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from receptionist where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma lễ tân
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["recepid"].ToString() == txtSearch.Text)
                            {
                                string sqlFindByID = "select * from receptionist where able = 1 and recepid = '" + txtSearch.Text + "'";
                                clearDataGridView(dataReceptionistTable);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã lễ tân này");
                        }
                    }
                    break;
                // Tim theo ten lễ tân
                case 1:
                    string sqlFindByName = "select * from receptionist where able = 1 and name like N'%" + txtSearch.Text + "%'";
                    clearDataGridView(dataReceptionistTable);
                    updateDataGridView(sqlFindByName);
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                    break;
            }
        }

        private void btnCreateReptionist_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                PanelInteraction.openForm(this, new ReceptionDescriptionDetail(panelWrapper, "", role, "create"), panelWrapper);
            }
            else
            {
                MessageBox.Show("Bạn không đủ ủy quyền để thêm lễ tân");
            }
        }

        private void dataReceptionistTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataReceptionistTable.CurrentCell == null) return;
            if (dataReceptionistTable.CurrentCell.ColumnIndex == 8)
            {
                string AssID = dataReceptionistTable[1, dataReceptionistTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new ReceptionDescriptionDetail(panelWrapper, AssID, role, "view"), panelWrapper);//sửa thông tin chi tiết phụ tá
            }
            else if (dataReceptionistTable.CurrentCell.ColumnIndex == 9)
            {
                if (role == 1)
                {
                    string RecepID = dataReceptionistTable[1, dataReceptionistTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new ReceptionDescriptionDetail(panelWrapper, RecepID, role, "update"), panelWrapper);//sửa thông tin chi tiết lễ tân
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để chỉnh sửa");
                }
            }
            else if (dataReceptionistTable.CurrentCell.ColumnIndex == 10)
            {
                if (role == 1)
                {
                    string RecepID = dataReceptionistTable[1, dataReceptionistTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new DeleteReceptionist(panelWrapper, RecepID, role, "delete"), panelWrapper);//Xóa thông tin chi tiết lễ tân
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
                }
            }
        }

        private void dataReceptionistTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
