using FireSharp.Response;
using N19_DentalClinic.model;
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

        FirebaseConnection firebaseConnection;

        public SignupForm()
        {
            InitializeComponent();
            firebaseConnection = new FirebaseConnection();
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


                SetResponse response = await firebaseConnection.Client.SetTaskAsync("Person/" + email, person);
                Person result = response.ResultAs<Person>();

                MessageBox.Show("Person Inserted: " + result);
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
