using N19_DentalClinic.service;
using N19_DentalClinic.service.impl;
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
    public partial class ForgotPasswordForm : Form
    {

        PersonService personService;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            personService = new PersonServiceImpl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            backToLoginForm();
        }

        private void backToLoginForm()
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (string.IsNullOrEmpty(email) )
            {
                MessageBox.Show("Email không được để trống");
                return;
            }

            bool isSuccess = await personService.ResetPassword(email);
            if (isSuccess)
            {
                MessageBox.Show("Truy cập đường link gửi qua email để đổi mật khẩu");
                backToLoginForm();

            }

        }
    }
}
