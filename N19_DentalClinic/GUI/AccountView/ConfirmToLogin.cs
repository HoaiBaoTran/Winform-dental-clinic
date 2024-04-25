using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.AccountView
{
    public partial class ConfirmToLogin : Form
    {
        private Form OriginForm;
        private Form LoginForm;
        public ConfirmToLogin(Form originForm, Form loginForm)
        {
            InitializeComponent();
            OriginForm = originForm;
            LoginForm = loginForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            OriginForm.Hide();
            LoginForm.ShowDialog();
            OriginForm?.Close();
            this.Close();
        }
    }
}
