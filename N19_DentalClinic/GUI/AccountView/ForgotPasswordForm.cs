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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;
using N19_DentalClinic.DAO;

namespace N19_DentalClinic.GUI.AccountView
{
    public partial class ForgotPasswordForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        string randomCode;
        public static string to;
        string accountID;
        DataInteraction data = new DataInteraction();

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            pnGetPass.BackColor = Color.FromArgb(72, 88, 130, 193);
            rdAdmin.Checked = false;
            rdReceptionist.Checked = false;
            rdDentist.Checked = false;
        }

        private async void btnGiveCode_Click(object sender, EventArgs e)
        {
            if (rdAdmin.Checked == false && rdDentist.Checked == false && rdReceptionist.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn vai trò của bạn");
                return;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập email");
                return;
            }
            else if (txtEmail.Text != "")
            {
                string sqlCheckEmail;
                if (rdAdmin.Checked)
                {
                    sqlCheckEmail = @"
                        select ac.accountid, ac.username, ac.password, ac.role, ad.email
                        from account ac
                        join Admin ad on ad.accountid = ac.accountid";
                }
                else if (rdDentist.Checked)
                {
                    sqlCheckEmail = @"
                        select ac.accountid, ac.username, ac.password, ac.role, d.email, d.denid
                        from account ac
                        join Dentist d on d.accountid = ac.accountid";
                }
                else
                {
                    sqlCheckEmail = @"
                        select ac.accountid, ac.username, ac.password, ac.role, re.email,re.recepid
                        from account ac
                        join Receptionist re on re.accountid = ac.accountid";
                }
                DataTable tableAcc = data.readData(sqlCheckEmail);
                if (tableAcc.Rows.Count > 0)
                {
                    bool flagEmail = true;
                    foreach (DataRow accountInfo in tableAcc.Rows)
                    {
                        //Tim email trong tai khoan
                        if (accountInfo["email"].ToString() == txtEmail.Text)
                        {
                            accountID = accountInfo["accountid"].ToString();
                            flagEmail = false;
                            break;
                        }
                    }
                    if (flagEmail)
                    {
                        MessageBox.Show("Email không tồn tại trong vai trò bạn chọn");
                        return;
                    }
                }
            }



            string email = txtEmail.Text;
            Random rand = new Random();
            randomCode = rand.Next(999999).ToString();
            MailMessage message = new MailMessage();
            to = txtEmail.Text;
            string from = "tatriet16@gmail.com";
            string pass = "rmxy kdvz bxjg cunt";
            string messageBody = "Mã xác thực của bạn là: " + randomCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Mã xác thực tạo lại mật khẩu";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Mã xác thực đã gửi thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnConfirmCode_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                MessageBox.Show("Vui lòng dán mã xác thực vào đây");
                return;
            }
            if (txtCode.Text == randomCode)
            {
                MessageBox.Show("Xác thực thành công");
                this.Hide();
                SetNewPassword newPassForm = new SetNewPassword(accountID);
                newPassForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Mã xác thực nhập sai thông tin");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMain loginForm = new LoginMain();
            loginForm.ShowDialog();
            this.Close();
        }

        private void ForgotPasswordForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void ForgotPasswordForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void ForgotPasswordForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
