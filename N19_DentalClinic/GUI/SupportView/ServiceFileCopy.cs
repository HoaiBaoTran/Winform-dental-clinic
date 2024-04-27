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
    public partial class ServiceFileCopy : Form
    {
        DataInteraction data = new DataInteraction();
        public ServiceFileCopy()
        {
            InitializeComponent();
        }

        private void ServiceFileCopy_Load(object sender, EventArgs e)
        {
            string sqlUpdateComboboxKindService = "select distinct kindService from service where able = 1";
            DataTable tableKindService = data.readData(sqlUpdateComboboxKindService);
            if (tableKindService.Rows.Count > 0)
            {
                foreach (DataRow row in tableKindService.Rows)
                {
                    cbKindService.Items.Add(row["kindService"].ToString());
                }
            }
            updateUiOnDataChange();
        }

        public void updateDataGridView(string sql)
        {
            btnSearch.BackColor = ColorTranslator.FromHtml("#" + "DBAF09");
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
                dataService.Columns[6].Name = "Loại dịch vụ";
                dataService.EnableHeadersVisualStyles = false;
                dataService.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
                dataService.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

                int countRow = 1;
                foreach (DataRow row in table.Rows)
                {
                    int price = ((int)row["price"]);
                    string formattedTotalRevenue = price.ToString("#,##0");
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["serviceID"],
                        (string)row["name"],
                        formattedTotalRevenue,
                        (string)row["calUnit"],
                        (string)row["note"],
                        (string)row["kindService"]
                    };
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select * from service where able = 1";
            DataTable table = data.readData(sql);
            int selectIndex = cbKindSearch.SelectedIndex;
            switch (selectIndex)
            {
                // Tim theo ma dich vu
                case 0:
                    if (table.Rows.Count > 0)
                    {
                        bool flagId = true;
                        foreach (DataRow row in table.Rows)
                        {
                            if (row["serviceId"].ToString() == tbSearch.Text)
                            {
                                string sqlFindByID = "select * from service where able = 1 and serviceId = '" + tbSearch.Text + "'";
                                clearDataGridView(dataService);
                                updateDataGridView(sqlFindByID);
                                flagId = false;
                            }
                        }
                        if (flagId)
                        {
                            MessageBox.Show("Không có mã dịch vụ này");
                        }
                    }
                    break;
                // Tim theo ten dich vu
                case 1:

                    string sqlFindByName = "select * from service where able = 1 and name like N'%" + tbSearch.Text + "%'";
                    clearDataGridView(dataService);
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

        private void cbKindService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kindService = cbKindService.Items[cbKindService.SelectedIndex].ToString();
            string sqlServiceSearch = $"select * from service where able = 1 and kindService = N'{kindService}' order by kindService asc ";
            clearDataGridView(dataService);
            updateDataGridView(sqlServiceSearch);
        }

        private void dataService_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataService.Rows.Count > 0)
            {
                if (dataService.CurrentCell.ColumnIndex == 8)
                {
                    string serviceId = dataService[1, dataService.CurrentCell.RowIndex].Value.ToString();
                    try
                    {
                        Clipboard.SetText(serviceId);
                        if (serviceId != "")
                        {
                            MessageBox.Show("Đã sao chép mã dịch vụ " + serviceId);
                        }
                    }
                    catch (Exception ex) { }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            updateUiOnDataChange();
        }
    }
}
