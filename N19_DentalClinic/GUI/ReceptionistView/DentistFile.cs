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
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
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
            else
            {
                MessageBox.Show("Hiện tại chưa có bệnh nhân nào!");
            }
        }



        private void dataDentistTable_MouseClick(object sender, MouseEventArgs e)
        {
            string DenID = dataDentistTable[1,dataDentistTable.CurrentCell.RowIndex].Value.ToString();
            if( dataDentistTable.CurrentCell.ColumnIndex == 8) {
                PanelInteraction.openForm(this, new DentistDescriptionDetail(panelWrapper, DenID), panelWrapper);
            }else if (dataDentistTable.CurrentCell.ColumnIndex == 9){
                PanelInteraction.openForm(this, new AppointmentForDentist(panelWrapper, DenID), panelWrapper);
            }
        }
    }
}
