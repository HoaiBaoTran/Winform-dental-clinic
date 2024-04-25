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
    public partial class DentistFileCopy : Form
    {
        DataInteraction data = new DataInteraction();
        public DentistFileCopy()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from dentist where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma nha si
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["denID"].ToString() == txtSearch.Text)
                            {
                                string sqlFindByID = "select * from dentist where able = 1 and denID = '" + txtSearch.Text + "'";
                                clearDataGridView(dataDentistTable);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã nha sĩ này");
                        }
                    }
                    break;
                // Tim theo ten nha si
                case 1:

                    string sqlFindByName = "select * from dentist where able = 1 and name like N'%" + txtSearch.Text + "%'";
                    clearDataGridView(dataDentistTable);
                    updateDataGridView(sqlFindByName);

                    break;
                case 2:
                    string sqlFindByFaculty = @$"
                        select de.*
                        from dentist de 
                        join Faculty fa on fa.FacID = de.FacID
                        where fa.name like N'%{txtSearch.Text}%'";
                    clearDataGridView(dataDentistTable);
                    updateDataGridView(sqlFindByFaculty);
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
                dataDentistTable.ColumnCount = 5;
                dataDentistTable.Columns[0].Name = "STT";
                dataDentistTable.Columns[1].Name = "Mã nha sĩ";
                dataDentistTable.Columns[2].Name = "Khoa";
                dataDentistTable.Columns[3].Name = "Họ tên";
                dataDentistTable.Columns[4].Name = "Email";


                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string facName = "";
                    string sqlFacName = "select name from faculty where able = 1 and facID = '" + (string)row["FacID"] + "'";
                    DataTable tableFacName = data.readData(sqlFacName);
                    if (tableFacName.Rows.Count > 0)
                    {
                        foreach (DataRow rowName in tableFacName.Rows)
                        {
                            facName = rowName["name"].ToString();
                        }
                    }
                    string[] rowString = new string[] { countRow.ToString(),
                        (string)row["denId"], facName,
                        (string)row["name"], (string)row["email"] };
                    dataDentistTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataDentistTable.AllowUserToAddRows = false;
            dataDentistTable.Columns[0].Width = 60;
            //Căn giữa nội dung cột đầu tiên
            dataDentistTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataDentistTable.EnableHeadersVisualStyles = false;
            dataDentistTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void DentistFileCopy_Load(object sender, EventArgs e)
        {
            string sql = "select * from dentist where able = 1";
            updateDataGridView(sql);
        }

        private void dataDentistTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataDentistTable.CurrentCell == null) return;
            if (dataDentistTable.CurrentCell.ColumnIndex == 1)
            {
                string denId = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                Clipboard.SetText(denId);
                MessageBox.Show("Đã sao chép mã nha sĩ " + denId);
            }
        }
    }
}
