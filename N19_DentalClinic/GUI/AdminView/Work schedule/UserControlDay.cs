using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.Work_schedule
{
    public partial class UserControlDay : UserControl
    {
        private string EmployID; // ID của nhân viên (đang sử dụng giá trị cố định cho mục đích minh họa)
        private List<Tuple<DateTime, DateTime, Color>> timeSpans = new List<Tuple<DateTime, DateTime, Color>>();
        DataInteraction data = new DataInteraction();

        public UserControlDay(string EmployID)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.EmployID = EmployID;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.Clear(Color.White); // Xóa nền trắng

            int totalHeight = this.ClientSize.Height;
            int totalWidth = this.ClientSize.Width;

            // Số lượng giờ trong một ngày
            int numberOfHours = 24;

            // Chiều cao của mỗi giờ
            int hourHeight = totalHeight / numberOfHours;

            // Vẽ các ô màu tương ứng với các khoảng thời gian đã được chỉ định
            for (int i = 0; i < timeSpans.Count; i++)
            {
                DateTime startTime = timeSpans[i].Item1;
                DateTime endTime = timeSpans[i].Item2;
                Color color = timeSpans[i].Item3;

                int startHour = startTime.Hour;
                int endHour = endTime.Hour;

                int top = startHour * hourHeight;
                int height = (endHour - startHour) * hourHeight;

                Rectangle rect = new Rectangle(0, top, totalWidth, height);

                // Vẽ màu cho vùng này
                using (SolidBrush brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, rect);
                }

                // Vẽ đường viền cho vùng màu
                g.DrawRectangle(Pens.Gray, rect);

                // Lấy thông tin về nội dung của ô màu
                string content = $"{startTime.ToString("HH:mm")} - {endTime.ToString("HH:mm")}";

                // Vẽ nội dung trực tiếp trên UserControl
                using (Font font = new Font("Cambria Math", 10))
                {
                    // Tính toán vị trí để căn giữa nội dung trong ô màu
                    SizeF textSize = g.MeasureString(content, font);
                    float x = rect.Left + (rect.Width - textSize.Width) / 2;
                    float y = rect.Top + (rect.Height - textSize.Height) / 2;

                    // Vẽ nội dung
                    g.DrawString(content, font, Brushes.Black, x, y);
                }
            }
        }

        // Phương thức để lấy màu ngẫu nhiên
        private Color GetRandomColor()
        {
            Random random = new Random();
            int r = random.Next(0, 256); // Đỏ
            int g = random.Next(0, 256); // Xanh lá cây
            int b = random.Next(0, 256); // Xanh lam
            return Color.FromArgb(r, g, b);
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }




        public void DisplayEvent(DateTime dayWorks)
        {

            string sqlGetCalendarToPaint;
            if (EmployID.Contains("DE"))
            {
                sqlGetCalendarToPaint = $"SELECT timeStart, timeEnd FROM dbo.Calendar_Dentist WHERE DenID = '{EmployID}' AND dayWorks = '{dayWorks}' AND able = 1";
            }
            else if (EmployID.Contains("AS"))
            {
                sqlGetCalendarToPaint = $"SELECT timeStart, timeEnd FROM dbo.Calendar_Assistant WHERE AssiID = '{EmployID}' AND dayWorks = '{dayWorks}' AND able = 1";
            }
            else
            {
                sqlGetCalendarToPaint = $"SELECT timeStart, timeEnd FROM dbo.Calendar_Receptionist WHERE RecID = '{EmployID}' AND dayWorks = '{dayWorks}' AND able = 1";
            }

            DataTable tableCalToPaint = data.readData(sqlGetCalendarToPaint);

            if (tableCalToPaint.Rows.Count > 0)
            {
                int flagCount = 0;
                foreach (DataRow row in tableCalToPaint.Rows)
                {
                    if(flagCount>0)
                    {
                        timeSpans.Clear(); // Xóa danh sách các khoảng thời gian trước 
                    }

                    DateTime startTime = (DateTime)row["timeStart"];
                    DateTime endTime = (DateTime)row["timeEnd"];
                    Color color = GetRandomColor(); // Lấy màu ngẫu nhiên
                    timeSpans.Add(new Tuple<DateTime, DateTime, Color>(startTime, endTime, color));
                    flagCount++;
                }
            }
        }


        private void UserControlDay_Load(object sender, EventArgs e)
        {

        }
    }
}

