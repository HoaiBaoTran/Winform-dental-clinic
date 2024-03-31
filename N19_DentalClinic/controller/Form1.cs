using System.Diagnostics;
using N19_DentalClinic.controller;
using N19_DentalClinic.database;

namespace N19_DentalClinic
{
    public partial class Form1 : Form
    {
        FirebaseConnection firebaseConnection;
        public Form1()
        {
            InitializeComponent();
            firebaseConnection = new FirebaseConnection();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPassword.Text;

            MessageBox.Show(email);
            MessageBox.Show(password);
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
