using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class ManageBill : Form
    {

        private int role;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();

        public ManageBill(Panel panel, int role)
        {
            InitializeComponent();
            panelWrapper = panel;
            this.role = role;
        }

        private void ManageBill_Load(object sender, EventArgs e)
        {
            updateUiOnDataChange();
        }

        public int updateDataGridView(string sql)
        {
            DataTable table = data.readData(sql);
            int countRow = 1;
            if (table.Rows.Count > 0)
            {
                dataBill.ColumnCount = 8;
                dataBill.Columns[0].Name = "STT";
                dataBill.Columns[1].Name = "Mã hóa đơn";
                dataBill.Columns[2].Name = "Tên bệnh nhân";
                dataBill.Columns[3].Name = "Tên lễ tân";
                dataBill.Columns[4].Name = "Tổng giá";
                dataBill.Columns[5].Name = "Ngày thanh toán";
                dataBill.Columns[6].Name = "Giờ thanh toán";
                dataBill.Columns[7].Name = "Xóa";
                dataBill.EnableHeadersVisualStyles = false;
                dataBill.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
                dataBill.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);


                foreach (DataRow row in table.Rows)
                {
                    int price = ((int)row["total_price"]);
                    string formattedTotalRevenue = price.ToString("#,##0");
                    string expiration = string.Empty;
                    string[] rowString = new string[] {
                        countRow.ToString(),
                        (string)row["billID"],
                        (string)row["patient_name"],
                        (string)row["receptionist_name"],
                        formattedTotalRevenue,
                        DateTimeConvert.convertDMY(row["payment_time"].ToString()),
                        DateTimeConvert.convertHMS(row["payment_time"].ToString()),
                        "Xóa" };
                    dataBill.Rows.Add(rowString);
                    countRow++;
                }
            }
            dataBill.AllowUserToAddRows = false;

            //Căn giữa nội dung cột đầu tiên
            dataBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataBill.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            return countRow;
        }

        private void updateUiOnDataChange()
        {

            dataBill.Rows.Clear();
            string sql = @"select b.bilID as billID, b.total_price, b.payment_time, p.name as patient_name, r.name as receptionist_name
                        from Bill b
                        join Patient p on p.PatID = b.PatID
                        join Bill_Recep br on br.bilID = b.bilID
                        join Receptionist r on r.RecepID = br.RecepID";
            updateDataGridView(sql);

        }
    }
}
