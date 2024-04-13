using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.DentistView;
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
            updateUiOnDataChange();
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
                dataService.EnableHeadersVisualStyles = false;
                dataService.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
                dataService.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

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

        private void updateUiOnDataChange()
        {
            dataService.Rows.Clear();
            string sql = "select * from Service";
            updateDataGridView(sql);
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddService addService = new AddService();
            if (addService.ShowDialog() == DialogResult.OK)
            {
                updateUiOnDataChange();
            }
        }

        private void dataService_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataService.Rows.Count > 0)
            {
                if (dataService.CurrentCell.ColumnIndex == 6)
                {
                    string serviceId = dataService[1, dataService.CurrentCell.RowIndex].Value.ToString();
                    string serviceName = dataService[2, dataService.CurrentCell.RowIndex].Value.ToString();
                    string title = "Xác nhận xóa";
                    string message = $"Bạn có chắc muốn xóa {serviceName} với id là {serviceId}???";
                    var confirmResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        string sql = @$"delete from Service 
                                        where serviceID = '{serviceId}'";
                        data.changeData(sql);
                        MessageBox.Show("Xóa thành công");
                        updateUiOnDataChange();
                    }
                }
                else
                {
                    string serviceId = dataService[1, dataService.CurrentCell.RowIndex].Value.ToString();
                    string serviceName = dataService[2, dataService.CurrentCell.RowIndex].Value.ToString();
                    string price = dataService[3, dataService.CurrentCell.RowIndex].Value.ToString();
                    string calUnit = dataService[4, dataService.CurrentCell.RowIndex].Value.ToString();
                    string note = dataService[5, dataService.CurrentCell.RowIndex].Value.ToString();
                    AddService addService = new AddService(serviceId, serviceName, price, calUnit, note);
                    if (addService.ShowDialog() == DialogResult.OK)
                    {
                        updateUiOnDataChange();
                    }
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string serviceId = tbSearch.Text.ToString();
            
            if (serviceId != string.Empty)
            {
                string sql = $"select * from service where serviceID = '{serviceId}'";
                dataService.Rows.Clear();
                updateDataGridView(sql);
            } else
            {
                updateUiOnDataChange();
            }
        }
    }
}
