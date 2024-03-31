using FireSharp.Response;
using N19_DentalClinic.model;
using N19_DentalClinic.repository;
using N19_DentalClinic.service;
using N19_DentalClinic.service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace N19_DentalClinic
{
    public partial class SignupForm : Form
    {
        private PersonService personService;

        public SignupForm()
        {
            InitializeComponent();
            personService = new PersonServiceImpl();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.ShowDialog();
            this.Close();
        }

        private async void btnSignup_Click(object sender, EventArgs e)
        {
            if (checkValidField())
            {
                string name = tbName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                string phoneNumber = tbPhoneNumber.Text;

                Person person = new Person(name, email, password, phoneNumber);
                /*
                Task<Person> personTask = personService.GetAccountByEmail(email);
                Person existPerson = await personTask;
                
                if (existPerson != null)
                {
                    MessageBox.Show("Email đã được sử dụng, hãy sử dụng email khác");
                }
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thành công");
                    personService.CreatePersonAccount(person);
                }
                */
                    personService.CreatePersonAccount(person);

            }

        }

        private bool checkValidField()
        {
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            string phoneNumber = tbPhoneNumber.Text;

            if (name == "" || email == "" || password == "" || confirmPassword == "" || phoneNumber == "")
            {
                MessageBox.Show("Vui lòng điền hết thông tin");
                return false;
            }

            if (!isValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ");
                return false;
            }

            if (!isValidPassword(password))
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự, chứa ít nhất 1 ký tự số và 1 ký tự đặc biệt");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp");
                return false;
            }
            return true;
        }

        private bool isValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }
    
        private bool isValidPassword(string password)
        {
            string regexPattern = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{6,}$";
            Regex regex = new Regex(regexPattern);
            return regex.IsMatch(password);
        }
    }
}
