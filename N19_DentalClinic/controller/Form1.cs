using N19_DentalClinic.controller;
using N19_DentalClinic.library;
using N19_DentalClinic.model;
using N19_DentalClinic.service;
using N19_DentalClinic.service.impl;

namespace N19_DentalClinic
{
    public partial class Form1 : Form
    {
        PersonService personService;
        public Form1()
        {
            InitializeComponent();
            personService = new PersonServiceImpl();    
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            Person person = new Person(email, password);
            personService.LoginAccount(person);
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
            this.Close();
        }
    }
}
