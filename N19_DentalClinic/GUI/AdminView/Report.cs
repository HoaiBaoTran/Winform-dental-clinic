using iTextSharp.text;
using iTextSharp.text.pdf;
using N19_DentalClinic.DAO;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Document = iTextSharp.text.Document;
using Paragraph = iTextSharp.text.Paragraph;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class Report : Form
    {
        
        private DateTime dayFrom = DateTime.Now;
        private DateTime dayTo = DateTime.Now;
        public static string connectionString = "Data Source=LAPTOP-Q3FMNND4\\SQLEXPRESS;Initial Catalog=QuanLyPhongKham;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        private string pdfFilePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Report.pdf";
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

        SqlConnection con = new SqlConnection(connectionString);

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
        // Tính tổng tiền
        private decimal CalculateTotalRevenue(DataTable dataTable)
        {
            decimal totalRevenue = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                totalRevenue += Convert.ToDecimal(row["total_price"]);
            }
            return totalRevenue;
        }

        //Nút tìm kiếm
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            chart1.Series["Doanh thu"].Points.Clear();
            if (cbDay.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thống kê theo thời gian");
                return;
            }
            if (cbChart.Text == "")
            {
                MessageBox.Show("Vui lòng chọn biểu đồ");
            }
            if (cbChart.Text == "Biểu đồ cột")
            {
                switch (cbDay.SelectedItem.ToString())
                {
                    case "Thống kê theo ngày":
                        chart1.Series["Doanh thu"].XValueType = ChartValueType.Date;
                        FillBarChartDay();                       
                        break;
                    case "Thống kê theo tháng":
                        chart1.Series["Doanh thu"].XValueType = ChartValueType.Int32;
                        FillBarChartMonth();
                        break;
                    case "Thống kê theo quý":
                        FillBarChartQuarter();
                        break;
                    case "Thống kê theo năm":
                        FillBarChartYear();
                        break;
                    default:
                        break;
                }
                // Đặt lại kiểu biểu đồ là cột
                //chart1.Series["Doanh thu"].ChartType = SeriesChartType.Column;
            }
            else if (cbChart.Text == "Biểu đồ tròn")
            {
                switch (cbDay.SelectedItem.ToString())
                {
                    case "Thống kê theo ngày":
                        FillPieChartDay();
                        break;

                    case "Thống kê theo tháng":
                        FillPieChartMonth();
                        break;
                    case "Thống kê theo quý":
                        FillPieChartQuarter();
                        break;
                    case "Thống kê theo năm":
                        FillPieChartYear();
                        break;
                    default:
                        break;
                }
                // Đặt lại kiểu biểu đồ là tròn
                chart1.Series["Doanh thu"].ChartType = SeriesChartType.Pie;
                chart1.Series["Doanh thu"].XValueType = ChartValueType.Auto;
            }
        }

        //nút xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (GetDataForReport().Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu thống kê");
                return;
            }

            // Tạo một tài liệu PDF mới
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(pdfFilePath, FileMode.Create));
            document.Open();

            // Thêm thông tin tựa đề
            Paragraph title = new Paragraph("BÁO CÁO DOANH THU " + title_ForReport + "\n\n", FontFactory.GetFont(FontFactory.TIMES_ROMAN, "20", Font.Bold));
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Thêm thông tin về thời gian báo cáo
            string timePeriodString = $"From {dayFrom.ToString("dd/MM/yyyy")} To {dayTo.ToString("dd/MM/yyyy")}\n\n";
            Paragraph timePeriod = new Paragraph(timePeriodString);
            timePeriod.Alignment = Element.ALIGN_RIGHT;
            document.Add(timePeriod);

            // Thêm biểu đồ vào tài liệu
            MemoryStream memoryStream = new MemoryStream();
            chart1.SaveImage(memoryStream, ChartImageFormat.Png);
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(memoryStream.GetBuffer());
            img.ScalePercent(70);
            img.Alignment = Element.ALIGN_CENTER;
            document.Add(img);

            // Thêm thông tin chi tiết vào tài liệu 
            Paragraph details = new Paragraph("Chi Tiet Bao Cao:\n\n");
            document.Add(details);

            // Thêm dữ liệu chi tiết vào tài liệu (ví dụ: doanh thu hàng ngày)
            DataTable dataTable = GetDataForReport();
            PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count);

            string[] customColumnNames = new string[] { "Ton tai du lieu", "Ma Hoa Don", "Tong Tien", "Thoi Gian Tao", "Ma Benh Nhan" };
            for (int i = 0; i < customColumnNames.Length; i++)
            {
                pdfTable.AddCell(new Phrase(customColumnNames[i]));
            }
            // Thêm tiêu đề cột
            //for (int i = 0; i < dataTable.Columns.Count; i++)
            //{
            //    pdfTable.AddCell(new Phrase(dataTable.Columns[i].ColumnName));
            //}
            // Thêm dữ liệu từ DataTable vào PDF
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < customColumnNames.Length; j++)
                {
                    pdfTable.AddCell(dataTable.Rows[i][j].ToString());
                }
            }
            document.Add(pdfTable);

            // Thêm tổng tiền vào tài liệu
            decimal totalRevenue = CalculateTotalRevenue(dataTable);
            string formattedTotalRevenue = totalRevenue.ToString("#,##0");
            Paragraph total = new Paragraph($"Tong Doanh Thu: {formattedTotalRevenue}đ\n\n");
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

        //Combobox chọn Ngày/Tháng/Quý/Năm
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
            else if (selectedValue == "Thống kê theo ngày")
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

        private string title_ForReport;
        // Tạo biểu đồ Cột theo ngày 
        private void FillBarChartDay()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = false;
            title_ForReport = "THEO NGÀY";
            dayFrom = dayFrom.Date;
            dayTo = dayTo.Date;
            if (dayFrom == dayTo)
            {
                dayFrom = dayFrom.Date;
                dayTo = dayTo.Date.AddDays(1).AddSeconds(-1);
            }
            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng chọn lại ngày");
            }
            else
            {
                fillBarChart_Final("SELECT payment_date, daily_revenue FROM CalculateDailyRevenue(@dateFrom, @dateTo)", "payment_date", "daily_revenue", "Doanh thu theo ngày", SeriesChartType.Column);
            }
        }

        // Tạo biểu đồ Cột theo tháng 
        private void FillBarChartMonth()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = false;
            title_ForReport = "THEO THÁNG";
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            DateTime startOfMonth = new DateTime(DateTime.Now.Year, Statistic_Month.monthFrom, 1);
            // Tính toán ngày cuối cùng của tháng monthFrom
            DateTime endOfMonth = new DateTime(DateTime.Now.Year, Statistic_Month.monthTo, 1);
            // Gán giá trị cho dayFrom và dayTo
            dayFrom = startOfMonth;
            dayTo = endOfMonth.AddMonths(1).AddSeconds(-1);

            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại tháng");
            }
            else
            {
                FillChart("SELECT payment_month, monthly_revenue FROM CalculateMonthlyRevenue(@dateFrom, @dateTo)", "payment_month", "monthly_revenue", "Doanh thu theo tháng", SeriesChartType.Column);
            }
        }

        //Hàm tạo biểu đồ cột quý
        private void FillBarChartQuarter()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = false;
            title_ForReport = "THEO QUÝ";
            // Xác định ngày đầu tiên của quý
            int quarterFrom = Statistic_Season.quarterFrom;
            int quarterTo = Statistic_Season.quarterTo;
            DateTime startQuarter = new DateTime(DateTime.Now.Year, (quarterFrom - 1) * 3 + 1, 1);

            // Xác định ngày cuối cùng của quý
            DateTime endQuarter = new DateTime(DateTime.Now.Year, (quarterTo) * 3, 1);

            dayFrom = startQuarter;
            dayTo = endQuarter.AddMonths(1).AddSeconds(-1);
            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại quý");
            }
            else
            {
                chart1.Series["Doanh thu"].IsVisibleInLegend = false;
                // Truy vấn cơ sở dữ liệu để lấy dữ liệu theo từng quý
                FillChart("SELECT payment_quarter, quarterly_revenue FROM CalculateQuarterlyRevenue(@dateFrom, @dateTo)", "payment_quarter", "quarterly_revenue", "Doanh thu theo quý", SeriesChartType.Column);
            }
        }

        // Tạo biểu đồ Cột theo năm 
        private void FillBarChartYear()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = false;
            title_ForReport = "THEO NĂM";
            int endYear = Statistic_Year.yearTo;
            DateTime startOfYear = new DateTime(Statistic_Year.yearFrom, 1, 1);
            // Tính toán ngày cuối cùng của 
            DateTime endOfYear = new DateTime(endYear, 12, 31).AddDays(1).AddSeconds(-1);
            // Gán giá trị cho dayFrom và dayTo
            dayFrom = startOfYear;
            dayTo = endOfYear;

            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại năm");
            }
            else
            {
                FillChart("SELECT payment_year, yearly_revenue FROM CalculateYearlyRevenue(@dateFrom, @dateTo)", "payment_year", "yearly_revenue", "Doanh thu theo năm", SeriesChartType.Column);
            }
        }

        // Tạo biểu đồ Tròn theo ngày 
        private void FillPieChartDay()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            title_ForReport = "THEO NGÀY";
            dayFrom = dayFrom.Date;
            dayTo = dayTo.Date;
            if (dayFrom == dayTo)
            {
                dayFrom = dayFrom.Date;
                dayTo = dayTo.Date.AddDays(1).AddSeconds(-1);
            }
            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng chọn lại ngày");
            }
            else
            {
                FillChart("SELECT CONVERT(varchar, payment_date, 103) AS payment_date, daily_revenue FROM CalculateDailyRevenue(@dateFrom, @dateTo)", "payment_date", "daily_revenue", "Doanh thu theo ngày", SeriesChartType.Pie);

                chart1.Series["Doanh thu"].LegendText = "#AXISLABEL";

                chart1.Series["Doanh thu"].Label = "#VALY (#PERCENT{P0})";
            }
        }

        // Tạo biểu đồ tròn theo tháng
        private void FillPieChartMonth()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            title_ForReport = "THEO THÁNG";
            DateTime startOfMonth = new DateTime(DateTime.Now.Year, Statistic_Month.monthFrom, 1);
            // Tính toán ngày cuối cùng của tháng monthFrom
            DateTime endOfMonth = new DateTime(DateTime.Now.Year, Statistic_Month.monthTo, 1);
            // Gán giá trị cho dayFrom và dayTo
            dayFrom = startOfMonth;
            dayTo = endOfMonth.AddMonths(1).AddSeconds(-1);

            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại tháng");
            }
            else
            {
                FillChart("SELECT payment_month, monthly_revenue FROM CalculateMonthlyRevenue(@dateFrom, @dateTo)", "payment_month", "monthly_revenue", "Doanh thu theo tháng", SeriesChartType.Pie);
                chart1.Series["Doanh thu"].LegendText = "#VALX";
                //month_Legend(dsMonthPie);
                chart1.Series["Doanh thu"].Label = "#VALY (#PERCENT{P0})";
            }
        }

        private void month_Legend(DataSet ds)
        {
            // Tạo mảng chứa tên các tháng
           // string[] monthNames = new string[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };

            // Sau khi lấy dữ liệu và gán cho biểu đồ Pie Chart
            chart1.Series["Doanh thu"].LegendText = "#AXISLABEL";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                // Lấy giá trị của cột "payment_month"
                string paymentMonthString = ds.Tables[0].Rows[i]["payment_month"].ToString();

                // Chia chuỗi thành tháng và năm
                string[] parts = paymentMonthString.Split('/');

                // Kiểm tra xem có đủ hai phần không (tháng và năm)
                if (parts.Length == 2)
                {
                    // Lấy giá trị tháng từ phần đầu tiên
                    int month;
                    if (int.TryParse(parts[0], out month))
                    {
                        // Kiểm tra xem giá trị tháng có nằm trong khoảng từ 1 đến 12 không
                        if (month >= 1 && month <= 12)
                        {
                            // Gán giá trị AxisLabel tương ứng với tên tháng
                            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month);
                            chart1.Series["Doanh thu"].Points[i].AxisLabel = monthName;
                        }
                    }
                }
            }

        }

        //Hàm tạo biểu đồ tròn quý
        private void FillPieChartQuarter()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            title_ForReport = "THEO QUÝ";
            // Xác định ngày đầu tiên của quý
            int quarterFrom = Statistic_Season.quarterFrom;
            int quarterTo = Statistic_Season.quarterTo;
            DateTime startQuarter = new DateTime(DateTime.Now.Year, (quarterFrom - 1) * 3 + 1, 1);

            // Xác định ngày cuối cùng của quý
            DateTime endQuarter = new DateTime(DateTime.Now.Year, (quarterTo) * 3, 1);

            dayFrom = startQuarter;
            dayTo = endQuarter.AddMonths(1).AddSeconds(-1);
            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại quý");
            }
            else
            {
                // Truy vấn cơ sở dữ liệu để lấy dữ liệu theo từng quý
                FillChart("SELECT payment_quarter, quarterly_revenue FROM CalculateQuarterlyRevenue(@dateFrom, @dateTo)", "payment_quarter", "quarterly_revenue", "Doanh thu theo quý", SeriesChartType.Pie);
                chart1.Series["Doanh thu"].LegendText = "#VALX";

                chart1.Series["Doanh thu"].Label = "#VALY (#PERCENT{P0})";
            }
        }

        //Tạo biểu đồ tròn theo năm
        private void FillPieChartYear()
        {
            chart1.Series["Doanh thu"].IsVisibleInLegend = true;
            title_ForReport = "THEO NĂM";
            int endYear = Statistic_Year.yearTo;
            DateTime startOfYear = new DateTime(Statistic_Year.yearFrom, 1, 1);
            // Tính toán ngày cuối cùng của 
            DateTime endOfYear = new DateTime(endYear, 12, 31).AddDays(1).AddSeconds(-1);
            // Gán giá trị cho dayFrom và dayTo
            dayFrom = startOfYear;
            dayTo = endOfYear;

            if (dayFrom > dayTo)
            {
                MessageBox.Show("Vui lòng nhập lại năm");
            }
            else
            {
                FillChart("SELECT payment_year, yearly_revenue FROM CalculateYearlyRevenue(@dateFrom, @dateTo)", "payment_year", "yearly_revenue", "Doanh thu theo năm", SeriesChartType.Pie);
                chart1.Series["Doanh thu"].LegendText = "#VALX";

                chart1.Series["Doanh thu"].Label = "#VALY (#PERCENT{P0})";
            }
        }
        
        // Hàm tạo Chart
        private void FillChart(string sqlCommand_, string xValueMember, string yValueMember, string chartTitle, SeriesChartType chartType)
        {
            
            // Thiết lập khoảng cách giữa các cột
            //chart1.Series["Doanh thu"].CustomProperties = "PointWidth=0.5";
            DataSet ds = new DataSet();
            

            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand(sqlCommand_, con);

            // Thêm các tham số vào câu lệnh SQL
            cmd.Parameters.AddWithValue("@dateFrom", dayFrom);
            cmd.Parameters.AddWithValue("@dateTo", dayTo);

            // Thực thi truy vấn
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            con.Open();
            adapt.Fill(ds);
            con.Close();
            
            if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Không có dữ liệu để tạo biểu đồ");
                return;
            }
            else
            {
                // Gán dữ liệu vào biểu đồ
                chart1.DataSource = ds;
                chart1.Series["Doanh thu"].XValueMember = xValueMember;
                chart1.Series["Doanh thu"].YValueMembers = yValueMember;
                chart1.Titles.Clear();
                chart1.Titles.Add(chartTitle);
                chart1.Series["Doanh thu"].ChartType = chartType;
                //   

                chart1.Series["Doanh thu"].IsValueShownAsLabel = true;
            }
        }

        //----------------     
        private void fillBarChart_Final(string sqlCommand_, string xValueMember, string yValueMember, string chartTitle, SeriesChartType chartType)
        {
            
            using (SqlConnection con = new SqlConnection(connectionString)) // Thay thế connectionString bằng chuỗi kết nối thích hợp
            using (SqlCommand cmd = new SqlCommand(sqlCommand_, con))
            using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@dateFrom", dayFrom);
                cmd.Parameters.AddWithValue("@dateTo", dayTo);

                DataSet ds = new DataSet();
                adapt.Fill(ds);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string paymentDateString = row[xValueMember].ToString();
                        DateTime paymentDate;

                        if (DateTime.TryParseExact(paymentDateString, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out paymentDate))
                        {
                            string formattedDate = paymentDate.ToString("dd/MM/yyyy");
                            row[xValueMember] = DateTime.ParseExact(formattedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        }                       
                    }

                    chart1.DataSource = ds;
                    chart1.Series["Doanh thu"].XValueMember = xValueMember;
                    chart1.Series["Doanh thu"].YValueMembers = yValueMember;
                    chart1.Titles.Clear();
                    chart1.Titles.Add(chartTitle);
                    chart1.Series["Doanh thu"].ChartType = chartType;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để tạo biểu đồ");
                }
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
