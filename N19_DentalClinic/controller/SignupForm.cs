using N19_DentalClinic.library;
using N19_DentalClinic.model;
using N19_DentalClinic.service;
using N19_DentalClinic.service.impl;

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
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirmPassword.Text;
            string phoneNumber = tbPhoneNumber.Text;

            if (MyLibrary.checkValidField(name, email, password, confirmPassword, phoneNumber))
            {
                Person person = new Person(name, email, password, phoneNumber);
                
                Task<Person> personTask = personService.GetAccountByEmail(email);
                Person existPerson = await personTask;
                
                if (existPerson != null)
                {
                    MessageBox.Show("Email đã được sử dụng, hãy sử dụng email khác");
                }
                else
                {
                    personService.CreatePersonAccount(person);
                }
            }
        }
    }
}
