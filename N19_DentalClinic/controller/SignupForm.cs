﻿using FireSharp.Response;
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
         
            if (checkValidField())
            {
                MessageBox.Show("Email không hợp lệ, vui lòng sử dụng email khác");
                MessageBox.Show("Email đã tồn tại, vui lòng sử dụng email khác");
                MessageBox.Show("Vui lòng đặt mật khẩu có độ dài tối thiểu 6 ký tự, 1 ký tự in hoa, 1 ký tự đặc biệt và 1 số");
                MessageBox.Show("Đăng kí thành công");

                /*
                string name = tbName.Text;
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                string phoneNumber = tbPhoneNumber.Text;

                Person person = new Person(name, email, password, phoneNumber);
                Person existPerson = personService.GetAccountByEmail(email).Result;
                MessageBox.Show("Get Account called");
                

                if (existPerson != null)
                {
                    MessageBox.Show("Email đã được sử dụng, hãy sử dụng email khác");
                }
                else
                {
                    MessageBox.Show(person.ToString());
                }

                //personService.CreatePersonAccount(person);
                */

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

            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu và xác nhận mật khẩu không khớp");
                return false;
            }
            return true;
        }
    }
}
