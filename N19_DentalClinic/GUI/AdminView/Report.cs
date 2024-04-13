using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;
using iTextSharp.text;
using iTextSharp.text.pdf;
using N19_DentalClinic.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class Report : Form
    {

        private DateTime dayFrom = DateTime.Now;
        private DateTime dayTo = DateTime.Now;
        public static string connectionString = "Data Source=LAPTOP-Q3FMNND4\\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        private string pdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\doanhthu.pdf";
        private object quanLyPhongKhamDataSet;
        Control originalPanel;
        public Report()
        {
            InitializeComponent();
            originalPanel = pnChange;
            cbDay.Items.Add("Thống kê theo ngày");
            cbDay.Items.Add("Thống kê theo tháng");
            cbDay.Items.Add("Thống kê theo quý");
            cbDay.Items.Add("Thống kê theo năm");

            cbChart.Items.Add("Biểu đồ cột");
            cbChart.Items.Add("Biểu đồ tròn");
        }



        private void FillChart()
        {
            chart1.Titles.Clear();
            DataTable dataTable = GetDataForChart();

            // Định dạng lại giá trị ngày để hiển thị dưới dạng ngày và tháng
            foreach (DataRow row in dataTable.Rows)
            {
                DateTime paymentDate = Convert.ToDateTime(row["payment_date"]);
                row["payment_date"] = paymentDate.ToString("dd/MM");
            }

            // Gán dữ liệu vào biểu đồ
            chart1.DataSource = dataTable;
            chart1.Series["Doanh thu"].XValueMember = "payment_date";
            chart1.Series["Doanh thu"].YValueMembers = "daily_revenue";
            chart1.Titles.Add("Doanh thu theo ngày");
            chart1.Series["Doanh thu"].IsValueShownAsLabel = true;
        }

        private DataTable GetDataForChart()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT CONVERT(varchar, payment_date, 103) AS payment_date, daily_revenue FROM CalculateDailyRevenue(@dateFrom, @dateTo)", con);
            cmd.Parameters.AddWithValue("@dateFrom", dayFrom);
            cmd.Parameters.AddWithValue("@dateTo", dayTo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private DataTable GetDataForReport()
        {
            // Truy vấn cơ sở dữ liệu hoặc lấy dữ liệu từ nguồn khác
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Bill WHERE total_price > 0 AND payment_time >= @dateFrom AND payment_time <= @dateTo", con);
            cmd.Parameters.AddWithValue("@dateFrom", dayFrom);
            cmd.Parameters.AddWithValue("@dateTo", dayTo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private decimal CalculateTotalRevenue(DataTable dataTable)
        {
            decimal totalRevenue = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["total_price"]);
            }
            return totalRevenue;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            FillChart();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
            document.Open();

            // Thêm thông tin tựa đề
            Paragraph title = new Paragraph("BÁO CÁO DOANH THU\n\n", FontFactory.GetFont(FontFactory.TIMES_ROMAN, "16", Font.Bold));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Thêm biểu đồ vào tài liệu
            MemoryStream memoryStream = new MemoryStream();
            chart1.SaveImage(memoryStream, ChartImageFormat.Png);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            img.Alignment = Element.ALIGN_CENTER;
            document.Add(img);

            // Thêm thông tin chi tiết vào tài liệu 
            Paragraph details = new Paragraph("Detail:\n\n");
            document.Add(details);

            // Thêm dữ liệu chi tiết vào tài liệu (ví dụ: doanh thu hàng ngày)
            DataTable dataTable = GetDataForReport();
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);
            // Thêm tiêu đề cột
            for (int i = 0; i < dataTable.Columns.Count; i++)
            {
                pdfTable.AddCell(new Phrase(dataTable.Columns[i].ColumnName));
            }
            // Thêm dữ liệu từ DataTable vào PDF
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    pdfTable.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(pdfTable);

            // Thêm thông tin về thời gian báo cáo
            Paragraph timePeriod = new Paragraph($"From {dayFrom.ToShortDateString()} To {dayTo.ToShortDateString()}\n\n");
            document.Add(timePeriod);

            // Thêm tổng tiền vào tài liệu
            decimal totalRevenue = CalculateTotalRevenue(dataTable);
            Paragraph total = new Paragraph($"Total: {totalRevenue.ToString()}\n\n");
            document.Add(total);

            // Đóng tài liệu
            document.Close();

            MessageBox.Show("Đã xuất file PDF thành công!");
        }

        private void Report_Load(object sender, EventArgs e)
        {
            txtDayFrom.Text = DateTimeConvert.convertDMY(dayFrom.ToString());
            txtDayTo.Text = DateTimeConvert.convertDMY(dayTo.ToString());
        }

        


        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedValue = cbDay.SelectedItem.ToString();
            if (selectedValue == "Thống kê theo tháng")
            {
                pnChange.Visible = false;
                pnEmpty.Controls.Clear();
                Statistic_Month pnMonth = new Statistic_Month();
                pnMonth.Dock = DockStyle.Fill;
                pnEmpty.Controls.Add(pnMonth);
            }
            else if (selectedValue == "Thống kê theo năm")
            {
                pnChange.Visible = false;
                pnEmpty.Controls.Clear();
                Statistic_Year pnYear = new Statistic_Year();
                pnYear.Dock = DockStyle.Fill;
                pnEmpty.Controls.Add(pnYear);
            }
            else if (selectedValue == "Thống kê theo quý")
            {
                pnChange.Visible = false;
                pnEmpty.Controls.Clear();
                Statistic_Season pnSea = new Statistic_Season();
                pnSea.Dock = DockStyle.Fill;

                pnEmpty.Controls.Add(pnSea);
            }
            else if(selectedValue == "Thống kê theo ngày")
            {
                pnChange.Visible = true;
                
            }
        }

        private void btnDayFrom_Click_1(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            dayFrom = calendarF.GetDateSelector();
            txtDayFrom.Text = DateTimeConvert.convertDMY(dayFrom.ToString());
        }

        private void btnDayTo_Click_1(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            dayTo = calendarF.GetDateSelector();
            txtDayTo.Text = DateTimeConvert.convertDMY(dayTo.ToString());
        }
    }
}
