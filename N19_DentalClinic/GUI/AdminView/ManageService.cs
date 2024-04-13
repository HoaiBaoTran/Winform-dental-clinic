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
    public partial class ManageService : Form
    {

        private int role;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();

        public ManageService(Panel panel, int role)
        {
            InitializeComponent();
            panelWrapper = panel;
            this.role = role;
        }

        private void ManageService_Load(object sender, EventArgs e)
        {
            string sql = "select * from Service";
            updateDataGridView(sql);
        }

        public void updateDataGridView(string sql)
        {
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                dataService.ColumnCount = 7;
                dataService.Columns[0].Name = "STT";
                dataService.Columns[1].Name = "Mã dịch vụ";
                dataService.Columns[2].Name = "Tên dịch vụ";
                dataService.Columns[3].Name = "Giá tiền";
                dataService.Columns[4].Name = "Đơn vị tính";
                dataService.Columns[5].Name = "Ghi chú";
                dataService.Columns[6].Name = "Xóa";

                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {

                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["serviceID"],
                        (string)row["name"],
                        ((int)row["price"]).ToString(),
                        (string)row["calUnit"],
                        (string)row["note"],
                        "Xóa" };
                    dataService.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataService.AllowUserToAddRows = false;

            //Căn giữa nội dung cột đầu tiên
            dataService.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataService.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {

        }
    }
}
