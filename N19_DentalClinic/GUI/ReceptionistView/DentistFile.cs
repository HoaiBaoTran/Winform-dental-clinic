using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class DentistFile : Form
    {
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        private int role;

        public DentistFile(Panel panelWrapper, int role)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
        }

        private void DentistFile_Load(object sender, EventArgs e)
        {
            string sql = "select * from Dentist where able = 1";
            updateDataGridView(sql);
        }



        private void dataDentistTable_MouseClick(object sender, MouseEventArgs e)
        {
            //Kiem tra bang co null không 
            if (dataDentistTable.CurrentCell == null) return;
            if (dataDentistTable.CurrentCell.ColumnIndex == 9)
            {
                string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, DenID, role, "view"), panelWrapper);//xem thông tin chi tiết nha sĩ
            }
            else if (dataDentistTable.CurrentCell.ColumnIndex == 10)
            {
                string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                PanelInteraction.openForm(this, new AppointmentForDentist(panelWrapper, DenID, role, "view"), panelWrapper);//xem thông tin lịch hẹn 
            }
            else if (dataDentistTable.CurrentCell.ColumnIndex == 11)
            {
                if(role == 1)
                {
                    string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, DenID, role, "update"), panelWrapper);//sửa thông tin chi tiết nha sĩ
                }else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để chỉnh sửa");
                }
            }
            else if (dataDentistTable.CurrentCell.ColumnIndex == 12)
            {
                if(role == 1)
                {
                    string DenID = dataDentistTable[1, dataDentistTable.CurrentCell.RowIndex].Value.ToString();
                    PanelInteraction.openForm(this, new DeleteDentist(panelWrapper, DenID, role, "delete"), panelWrapper);//Xóa thông tin chi tiết nha sĩ
                }
                else
                {
                    MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
                }
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
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + "DBAF09");
            btnCreateDentist.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataDentistTable.ColumnCount = 13;
                dataDentistTable.Columns[0].Name = "STT";
                dataDentistTable.Columns[1].Name = "Mã nha sĩ";
                dataDentistTable.Columns[2].Name = "Khoa";
                dataDentistTable.Columns[3].Name = "Họ tên";
                dataDentistTable.Columns[4].Name = "Năm sinh";
                dataDentistTable.Columns[5].Name = "Địa chỉ";
                dataDentistTable.Columns[6].Name = "Số điện thoại";
                dataDentistTable.Columns[7].Name = "Email";
                dataDentistTable.Columns[8].Name = "Giới tính";
                dataDentistTable.Columns[9].Name = "Thông tin chi tiết";
                dataDentistTable.Columns[10].Name = "Xem lịch hẹn";
                dataDentistTable.Columns[11].Name = "Chỉnh sửa";
                dataDentistTable.Columns[12].Name = "Xóa";
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
                    string facName = "";
                    string sqlFacName = "select name from faculty where able = 1 and facID = '" + (string)row["FacID"] + "'";
                    DataTable tableFacName = data.readData(sqlFacName);
                    if(tableFacName.Rows.Count > 0)
                    {
                        foreach(DataRow rowName in  tableFacName.Rows)
                        {
                            facName = rowName["name"].ToString();
                        }
                    }
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["DenID"],
                        facName,
                        (string)row["name"],
                        DateTimeConvert.convertDMY(row["birthday"].ToString()),
                        (string)row["address"], (string)row["phone_number"],
                        (string)row["email"], gender, "Thông tin chi tiết",
                        "Lịch hẹn",
                        "Chỉnh sửa",
                        "Xóa"
                    };
                    dataDentistTable.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataDentistTable.AllowUserToAddRows = false;
            dataDentistTable.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataDentistTable.Columns[0].Width = 60;


            dataDentistTable.EnableHeadersVisualStyles = false;
            dataDentistTable.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
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

        private void btnCreateDentist_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, "", role, "create"), panelWrapper);
            }
            else
            {
                MessageBox.Show("Bạn không đủ ủy quyền để thêm nha sĩ");
            }
        }

    }
}
