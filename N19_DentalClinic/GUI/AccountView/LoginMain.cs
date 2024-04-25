using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.AdminView;
using N19_DentalClinic.GUI.DentistView;
using N19_DentalClinic.GUI.ReceptionistView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace N19_DentalClinic.GUI.AccountView
{
    public partial class LoginMain : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        DataInteraction data = new DataInteraction();
        public LoginMain()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnBackLogin.BackColor = Color.FromArgb(72, 88, 130, 193);
        }


        private void btnToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterMain registerForm = new RegisterMain();
            registerForm.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdAdmin.Checked == false && rdDentist.Checked == false && rdReceptionist.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn vai trò của bạn");
                return;
            }
            else if (txtAccountName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            else if (txtNamePassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            string userName = txtAccountName.Text;
            string passWord = txtNamePassword.Text;
            string roleUser = "";
            string sqlGetAccount = "";
            //Kiem tra tai khoan theo vai tro
            if (rdAdmin.Checked)
            {
                sqlGetAccount = @"
                    select ac.username, ac.password, ac.role, ad.email
                    from account ac
                    join Admin ad on ad.accountid = ac.accountid";
                roleUser = "A";
            }
            else if (rdDentist.Checked)
            {
                sqlGetAccount = @"
                    select ac.username, ac.password, ac.role, d.email, d.denid
                    from account ac
                    join Dentist d on d.accountid = ac.accountid";
                roleUser = "C";
            }
            else if (rdReceptionist.Checked)
            {
                sqlGetAccount = @"
                    select ac.username, ac.password, ac.role, re.email,re.recepid
                    from account ac
                    join Receptionist re on re.accountid = ac.accountid";
                roleUser = "B";
            }
            DataTable tableAcc = data.readData(sqlGetAccount);
            if (tableAcc.Rows.Count > 0)
            {
                foreach (DataRow acc in tableAcc.Rows)
                {
                    if ((acc["username"].ToString() == userName || acc["email"].ToString() == userName) && acc["password"].ToString() == passWord && acc["role"].ToString() == roleUser)
                    {
                        switch (roleUser)
                        {
                            case "A":
                                this.Hide();
                                Admin ad = new Admin();
                                ad.ShowDialog();
                                this.Close();
                                break;
                            case "B":
                                this.Hide();
                                Receptionist recep = new Receptionist(acc["recepid"].ToString());
                                recep.ShowDialog();
                                this.Close();
                                break;
                            case "C":
                                this.Hide();
                                Dentist den = new Dentist(acc["denid"].ToString());
                                den.ShowDialog();
                                this.Close();
                                break;
                        }
                    }
                }
                MessageBox.Show("Bạn chọn sai vai trò, tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void lbForgotPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.ShowDialog();
            this.Close();
        }

        private void LoginMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LoginMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
