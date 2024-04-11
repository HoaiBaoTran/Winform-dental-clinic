using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI.ReceptionistView
{
    public partial class DentistFile : Form
    {
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();  
        public DentistFile(Panel panelWrapper)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
        }

        private void DentistFile_Load(object sender, EventArgs e)
        {
            string sql = "select * from Dentist";
            updateDataGridView(sql);
        }



        private void dataDentistTable_MouseClick(object sender, MouseEventArgs e)
        {
            if( dataDentistTable.CurrentCell.ColumnIndex == 8) {
                string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, DenID), panelWrapper);
            }else if (dataDentistTable.CurrentCell.ColumnIndex == 9){
                string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new AppointmentForDentist(panelWrapper, DenID), panelWrapper);
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
                dtgv.AllowUserToAddRows = true;
            }
        }

        public void updateDataGridView(string sql)
        {
            DataTable table = data.readData(sql);
            if(table.Rows.Count>0)
            {
                dataDentistTable.ColumnCount = 10;
                dataDentistTable.Columns[0].Name = "STT";
                dataDentistTable.Columns[1].Name = "Mã nha sĩ";
                dataDentistTable.Columns[2].Name = "Họ tên";
                dataDentistTable.Columns[3].Name = "Năm sinh";
                dataDentistTable.Columns[4].Name = "Địa chỉ";
                dataDentistTable.Columns[5].Name = "Số điện thoại";
                dataDentistTable.Columns[6].Name = "Email";
                dataDentistTable.Columns[7].Name = "Giới tính";
                dataDentistTable.Columns[8].Name = "Thông tin chi tiết";
                dataDentistTable.Columns[9].Name = "Xem lịch hẹn";
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
                    string[] rowString = new string[] { countRow.ToString(), (string)row["DenID"], (string)row["name"], DateTimeConvert.convertDMY(row["birthday"].ToString()), (string)row["address"], (string)row["phone_number"], (string)row["email"], gender, "Thông tin chi tiết", "Lịch hẹn" };
                    dataDentistTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataDentistTable.AllowUserToAddRows = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from dentist";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch(selectIndex)
            {
                // Tim theo ma nha si
                case 0:
                    if(table.Rows.Count >0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["denID"].ToString() == txtSearch.Text)
                            {
                                string sqlFindByID = "select * from dentist where denID = '" + txtSearch.Text + "'";
                                clearDataGridView(dataDentistTable);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if(flagId)
                        {
                            MessageBox.Show("Không có mã nha sĩ này");
                        }
                    }
                    break;
                // Tim theo ten nha si
                case 1:
                    
                    string sqlFindByName = "select * from dentist where name like N'%" + txtSearch.Text + "%'";
                    clearDataGridView(dataDentistTable);
                    updateDataGridView(sqlFindByName);
                    
                    break;
                default:
                    MessageBox.Show("Vui lòng chọn loại tìm kiếm");
                    break;
            }
        }
    }
}
