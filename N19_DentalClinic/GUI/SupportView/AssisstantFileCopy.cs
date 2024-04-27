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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.GUI.SupportView
{
    public partial class AssisstantFileCopy : Form
    {
        DataInteraction data = new DataInteraction();
        public AssisstantFileCopy()
        {
            InitializeComponent();
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
                                clearDataGridView(DataAssisstantTable);
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
                    clearDataGridView(DataAssisstantTable);
                    updateDataGridView(sqlFindByName);
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                    break;
            }
        }

        public void clearDataGridView(DataGridView dtgv)
        {
            try
            {
                dtgv.Rows.Clear();
            }
            finally
            {
                dtgv.AllowUserToAddRows = false;
            }
        }

        public void updateDataGridView(string sql)
        {
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                DataAssisstantTable.ColumnCount = 4;
                DataAssisstantTable.Columns[0].Name = "STT";
                DataAssisstantTable.Columns[1].Name = "Mã phụ tá";
                DataAssisstantTable.Columns[2].Name = "Họ tên";
                DataAssisstantTable.Columns[3].Name = "Email";


                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] { countRow.ToString(),
                        (string)row["assiId"],
                        (string)row["name"], (string)row["email"] };
                    DataAssisstantTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            DataAssisstantTable.AllowUserToAddRows = false;
            DataAssisstantTable.Columns[0].Width = 60;
            //Căn giữa nội dung cột đầu tiên
            DataAssisstantTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataAssisstantTable.EnableHeadersVisualStyles = false;
            DataAssisstantTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void DataAssisstantTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (DataAssisstantTable.CurrentCell == null) return;
            if (DataAssisstantTable.CurrentCell.ColumnIndex == 1)
            {
                string assiId = DataAssisstantTable[1, DataAssisstantTable.CurrentCell.RowIndex].Value.ToString();
                try
                {
                    Clipboard.SetText(assiId);
                    if(assiId!="")
                    {
                        MessageBox.Show("Đã sao chép mã phụ tá: " + assiId);
                    }
                }
                catch (Exception ex) { }
            }
        }

        private void AssisstantFileCopy_Load(object sender, EventArgs e)
        {
            string sql = "select * from assisstant where able = 1";
            updateDataGridView(sql);
        }
    }
}
