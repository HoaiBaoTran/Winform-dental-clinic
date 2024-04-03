using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.controller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            openLoginForm();
        }

        private void openLoginForm()
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
        }

        private void openProfileForm()
        {
            /*
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
            */
            MessageBox.Show("Đây là form quản lý thông tin cá nhân");
        }

        private void openScheduleForm()
        {
            /*
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
            */
            MessageBox.Show("Đây là form xem thời khóa biểu");
        }

        private void openSalaryForm()
        {
            /*
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
            */
            MessageBox.Show("Đây là form tiền lương");
        }

        private void openReportForm()
        {
            /*
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
            */
            MessageBox.Show("Đây là form báo cáo");
        }

        private void openSecurityForm()
        {
            /*
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
            */
            MessageBox.Show("Đây là form bảo mật");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openProfileForm();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            openScheduleForm();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            openSalaryForm();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            openReportForm();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            openSecurityForm();
        }
    }
}
