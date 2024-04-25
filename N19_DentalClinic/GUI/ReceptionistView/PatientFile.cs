using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.ReceptionistView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI
{
    public partial class PatientFile : Form
    {
        private int role;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        public PatientFile(Panel panelWrapper, int role)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
        }

        private void PatientFile_Load(object sender, EventArgs e)
        {
            string sql = "select * from Patient where able = 1";
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
                dtgv.AllowUserToAddRows = false;
            }
        }

        public void updateDataGridView(string sql)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + "DBAF09");
            createNewPat.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataPatientTable.ColumnCount = 12;
                dataPatientTable.Columns[0].Name = "STT";
                dataPatientTable.Columns[1].Name = "Mã bệnh nhân";
                dataPatientTable.Columns[2].Name = "Họ tên";
                dataPatientTable.Columns[3].Name = "Năm sinh";
                dataPatientTable.Columns[4].Name = "Địa chỉ";
                dataPatientTable.Columns[5].Name = "Số điện thoại";
                dataPatientTable.Columns[6].Name = "Email";
                dataPatientTable.Columns[7].Name = "Giới tính";
                dataPatientTable.Columns[8].Name = "Lịch sử khám";
                dataPatientTable.Columns[9].Name = "Thông tin chi tiết";
                dataPatientTable.Columns[10].Name = "Chỉnh sửa";
                dataPatientTable.Columns[11].Name = "Xóa";


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
                    string[] rowString = new string[] { countRow.ToString(), (string)row["PatId"], (string)row["name"], DateTimeConvert.convertDMY(row["birthday"].ToString()), (string)row["address"], (string)row["number"], (string)row["email"], gender, "Lịch sử khám", "Thông tin chi tiết", "Chỉnh sửa", "Xóa" };
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

        private void dataPatientTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataPatientTable.CurrentCell == null) return;
            if (dataPatientTable.CurrentCell.ColumnIndex == 8)
            {
                string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new HistoryCheckUp(panelWrapper, patId,role), panelWrapper);
            }
            else if (dataPatientTable.CurrentCell.ColumnIndex == 9) // Xem thong tin benh nhan
            {

                string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new PatientDecriptionDetail(panelWrapper, patId, role, "view"), panelWrapper);
            }
            else if (dataPatientTable.CurrentCell.ColumnIndex == 10) // Sửa thong tin benh nhan
            {
                if (role != 3)
                {
                    string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new PatientDecriptionDetail(panelWrapper, patId, role, "update"), panelWrapper);
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để chỉnh sửa");
                }
            }
            else if (dataPatientTable.CurrentCell.ColumnIndex == 11) // Xóa thong tin benh nhan
            {
                if (role != 3)
                {
                    string patId = dataPatientTable[1, dataPatientTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new DeletePatient(panelWrapper, patId, role, "delete"), panelWrapper);
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
                }
            }
        }

        private void createNewPat_Click(object sender, EventArgs e)
        {
            if(role != 3)
            {
                PanelInteraction.openForm(this, new PatientDecriptionDetail(panelWrapper, "", role, "create"), panelWrapper);
            }else
            {
                MessageBox.Show("Bạn không đủ thẩm quyền để thêm bệnh nhân");
            }
        }

    }
}
