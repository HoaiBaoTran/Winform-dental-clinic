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
    public partial class PatientFileCopy : Form
    {
        DataInteraction data = new DataInteraction();
        public PatientFileCopy()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from patient where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma benh nhan
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["patId"].ToString() == txtSearch.Text)
                            {
                                string sqlFindByID = "select * from patient where able = 1 and patId = '" + txtSearch.Text + "'";
                                clearDataGridView(dataPatientTable);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã bệnh nhân này");
                        }
                    }
                    break;
                // Tim theo ten benh nhan
                case 1:

                    string sqlFindByName = "select * from patient where able = 1 and name like N'%" + txtSearch.Text + "%'";
                    clearDataGridView(dataPatientTable);
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
                dataPatientTable.ColumnCount = 4;
                dataPatientTable.Columns[0].Name = "STT";
                dataPatientTable.Columns[1].Name = "Mã bệnh nhân";
                dataPatientTable.Columns[2].Name = "Họ tên";
                dataPatientTable.Columns[3].Name = "Email";


                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    string[] rowString = new string[] { countRow.ToString(), (string)row["PatId"], (string)row["name"], (string)row["email"] };
                    dataPatientTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataPatientTable.AllowUserToAddRows = false;
            dataPatientTable.Columns[0].Width = 60;
            //Căn giữa nội dung cột đầu tiên
            dataPatientTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataPatientTable.EnableHeadersVisualStyles = false;
            dataPatientTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
        }

        private void PatientFileCopy_Load(object sender, EventArgs e)
        {
            string sql = "select * from patient where able = 1";
            updateDataGridView(sql);
        }

        private void dataPatientTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataPatientTable.CurrentCell == null) return;
            if (dataPatientTable.CurrentCell.ColumnIndex == 1)
            {
                try
                {
                    string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                    Clipboard.SetText(patId);
                    if(patId!="")
                    {
                        MessageBox.Show("Đã sao chép mã bệnh nhân " + patId);
                    }
                }
                catch (Exception ex) 
                {
                }    
            }
        }
    }
}
