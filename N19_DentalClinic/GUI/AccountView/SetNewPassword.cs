using N19_DentalClinic.DAO;
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
    public partial class SetNewPassword : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        string accountID;
        DataInteraction data = new DataInteraction();
        public SetNewPassword(string accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới");
                return;
            }
            else if (txtConfirmNewPass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào nhập lại mật khẩu");
                return;
            }
            if (txtConfirmNewPass.Text != txtNewPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp");
                return;
            }
            string sqlAccount = $"update account set password = '{txtNewPass.Text.ToString()}' where accountId = '{accountID}'";
            data.changeData(sqlAccount);
            MessageBox.Show("Tạo mật khẩu mới thành công");
            this.Hide();
            LoginMain loginForm = new LoginMain();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotForm = new ForgotPasswordForm();
            forgotForm.ShowDialog();
            this.Close();
        }

        private void SetNewPassword_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void SetNewPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void SetNewPassword_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void SetNewPassword_Load(object sender, EventArgs e)
        {
            pnBackLogin.BackColor = Color.FromArgb(72, 88, 130, 193);
        }
    }
}
