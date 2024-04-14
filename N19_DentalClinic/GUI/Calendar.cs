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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Serialization;
using N19_DentalClinic.DAO;
using Microsoft.Win32;

namespace N19_DentalClinic.GUI
{
    public partial class Calendar : Form
    {
        #region Properties
        private List<List<Button>> matrix;
        private DateTime dateSelector = DateTime.Today;
        
        #endregion

        private List<String> DateOfWeek = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday"
                                                              , "Friday", "Saturday" ,"Sunday"};

        //Start
        public Calendar()
        {
            InitializeComponent();
            LoadMatrix();
        }

        // Tạo ma trận
        void LoadMatrix()
        {
            matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayofColumn; i++)
            {
                matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += Btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    matrix[i].Add(btn);
                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }
            setDefaultDate();
        }
        private DateTime dateAccept;
        private Button lastClickedButton;
        private Button btnClickDTPK;
        private void Btn_Click(object? sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (!string.IsNullOrEmpty(clickedButton.Text))
            {
                setBtn_Click(clickedButton);
                btnClickDTPK = clickedButton;
            }
            else
            {
                MessageBox.Show("Không thể chọn","Thông báo");
                return;
            }
        }

        private void setBtn_Click(Button clickedButton)
        {          
            if (lastClickedButton != null && lastClickedButton.Tag is DateTime today)
            {
                if (today.Date != DateTime.Today)
                {
                    lastClickedButton.BackColor = SystemColors.Window; // Màu nền mặc định của control
                }
            }
            // Lấy giá trị ngày từ thuộc tính Tag của nút
            if (clickedButton.Tag is DateTime selectedDate)
            {
                if (selectedDate.Date != DateTime.Today)
                {
                    clickedButton.BackColor = Color.Green;
                }
                dateAccept = selectedDate;
                lastClickedButton = clickedButton;
                dtpkDate.Value = dateAccept;
            }               
        }

        int dayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if (date.Year % 4 == 0 && date.Year % 100 != 0 || date.Year % 400 == 0)
                    {
                        return 29;
                    }
                    else
                        return 28;
                default:
                    return 30;
            }
        }
        Button btnHomNay;
        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;
            for (int i = 1; i <= dayOfMonth(date); i++)
            {
                int column = DateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = matrix[line][column];
                btn.Text = i.ToString();
                btn.Tag = useDate;
                //Ngày hôm nay 
                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.LightBlue;
                    btnHomNay = btn;
                }
                //Ngày được chọn 
                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Green;
                    dateAccept = useDate;
                }

                if (column >= 6)
                {
                    line++;
                }

                useDate = useDate.AddDays(1);
            }
        }
        //Kiểm tra ngày giống nhau
        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }
        //Clear khi qua tháng khác
        void ClearMatrix()
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    Button btn = matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.White;
                }
            }
        }
        //Ngày mặc định
        void setDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
            dateSelector = dtpkDate.Value;
        }

        // Chọn ngày trên DateTimePicKer 
        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
            
        }
        
        //Button Tháng trước
        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }
        //Button Tháng sau
        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }
        //Button Hôm nay
        private void btnToDay_Click(object sender, EventArgs e)
        {
            setDefaultDate();
            dateAccept = DateTime.Now;          
        }

        public DateTime GetDateSelector()
        {
            return dateSelector;
        }

        public void setDateSelector(DateTime dateSelector)
        {
            this.dateSelector = dateSelector;
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            setDateSelector(dateAccept);
            this.Close();
        }
    }
}
