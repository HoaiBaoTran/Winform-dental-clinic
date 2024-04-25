using N19_DentalClinic.DAO;
using N19_DentalClinic.DTO;
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
    public partial class RegisterMain : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        DataInteraction data = new DataInteraction();
        public RegisterMain()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Cap nhat khoa trong combobox
            pnBackLogin.BackColor = Color.FromArgb(72, 88, 130, 193);
            lbFaculty.Hide();
            cbFaculty.Hide();
            string sqlFacload = "select name from Faculty where able = 1";
            DataTable tableFacLoad = data.readData(sqlFacload);
            foreach (DataRow rowFacLoad in tableFacLoad.Rows)
            {
                cbFaculty.Items.Add(rowFacLoad["name"].ToString());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdDentist.Checked)
            {
                lbFaculty.Show();
                cbFaculty.Show();
            }
            else
            {
                lbFaculty.Hide();
                cbFaculty.Hide();
            }
        }

        private void lbToLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginMain loginMain = new LoginMain();
            loginMain.ShowDialog();
            this.Close();
        }

        private void btnToRegister_Click(object sender, EventArgs e)
        {
            string mss = "";
            if (txtAccountName.Text == "")
            {
                mss = "Vui lòng nhập tên tài khoản";
            }
            else if (txtPass.Text == "")
            {
                mss = "Vui lòng nhập mật khẩu";
            }
            else if (txtConfirmPass.Text == "")
            {
                mss = "Vui lòng nhập phần nhập lại mật khẩu";
            }
            else if(txtConfirmPass.Text != txtPass.Text)
            {
                mss = "Mật khẩu xác nhận không khớp";
            }
            else if (txtNameUser.Text == "")
            {
                mss = "Vui lòng nhập họ tên";
            }
            else if (txtEmail.Text == "")
            {
                mss = "Vui lòng nhập email";
            }
            else if (CheckFieldInfo.checkEmail(txtEmail.Text) == false)
            {
                mss = "Email không hợp lệ";
            }
            else if (txtPhoneNumber.Text == "")
            {
                mss = "Vui lòng nhập số điện thoại";
            }
            else if (CheckFieldInfo.checkPhoneNumber(txtPhoneNumber.Text) == false)
            {
                mss = "Số điện thoại không hợp lệ";
            }
            else if (rdDentist.Checked == false && rdReceptionist.Checked == false)
            {
                mss = "Vui lòng chọn vai trò";
            }

            if (mss != "")
            {
                MessageBox.Show(mss);
                return;
            }

            //Xu li du lieu
            string accName = txtAccountName.Text;
            string email = txtEmail.Text;

            //Kiem tra thong tin co ton tai chua (username, email)
            string sqlCheckAccAndEmailInDentist =
                @"select ac.username,d.email from account ac
                join dentist d on d.accountid = ac.accountid";
            DataTable tableCheckExtinctAcc = data.readData(sqlCheckAccAndEmailInDentist);
            if(tableCheckExtinctAcc.Rows.Count > 0)
            {
                foreach(DataRow acc in tableCheckExtinctAcc.Rows)
                {
                    if (acc["username"].ToString() == accName)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại");
                        return;
                    }
                    if (acc["email"].ToString() == email)
                    {
                        MessageBox.Show("Email đã tồn tại");
                        return;
                    }
                }
            }

            string sqlCheckAccAndEmailInReceptionist =
                @"select ac.username,re.email from account ac
                join receptionist re on re.accountid = ac.accountid";
            DataTable tableCheckExtinctAccRecep = data.readData(sqlCheckAccAndEmailInReceptionist);
            if (tableCheckExtinctAccRecep.Rows.Count > 0)
            {
                foreach (DataRow acc in tableCheckExtinctAccRecep.Rows)
                {
                    if (acc["username"].ToString() == accName)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại");
                        return;
                    }
                    if (acc["email"].ToString() == email)
                    {
                        MessageBox.Show("Email đã tồn tại");
                        return;
                    }
                }
            }

            string sqlCheckAccAndEmailInAdmin =
                @"select ac.username,ad.email from account ac
                join admin ad on ad.accountid = ac.accountid";
            DataTable tableCheckExtinctAccAdmin = data.readData(sqlCheckAccAndEmailInAdmin);
            if (tableCheckExtinctAccAdmin.Rows.Count > 0)
            {
                foreach (DataRow acc in tableCheckExtinctAccAdmin.Rows)
                {
                    if (acc["username"].ToString() == accName)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại");
                        return;
                    }
                    if (acc["email"].ToString() == email)
                    {
                        MessageBox.Show("Email đã tồn tại");
                        return;
                    }
                }
            }

            //Tao tai khoan bac si
            if (rdDentist.Checked)
            {
                string userName = txtNameUser.Text;
                string passDen = txtPass.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string accountID = "";

                //Xu li khoa
                string facID = "";
                if(cbFaculty.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn khoa");
                    return;
                }
                string sqlFal = "select * from Faculty where able = 1 and name = N'" + cbFaculty.Text + "'";
                DataTable tableFal = data.readData(sqlFal);
                if (tableFal.Rows.Count > 0)
                {
                    foreach (DataRow rowfal in tableFal.Rows)
                    {
                        facID = rowfal["facId"].ToString();
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại khoa này");
                    return;
                }

                //Tao tai khoan nha si
                string sqlNewAccDen = $"exec procAddAccount '{accName}','{passDen}','C'";
                data.changeData(sqlNewAccDen);


                //Lay id tai khoan moi nhat
                string sqlLastAccount = "select TOP(1)accountid from account order by accountid desc ";
                DataTable tableLastAcc = data.readData(sqlLastAccount);
                if(tableLastAcc.Rows.Count > 0)
                {
                    foreach(DataRow acc in  tableLastAcc.Rows)
                    {
                        accountID = acc["accountid"].ToString();
                        break;
                    }
                }

                //Them thong tin co ban cua nha si
                string sqlInfoDen = $@"exec procAddDentist 
                    N'{userName}', N'', '{email}', '{phoneNumber}', 0,  '{facID}',
                    N'', 'F', N'Việt Nam', 1, '{DateTimeConvert.convertSqlTime(DateTime.Today.ToString())}',
                    '{accountID}'";
                data.changeData(sqlInfoDen);
                MessageBox.Show("Tạo tài khoản thành công");

            }
            else // Tao tai khoan le tan
            {
                string userName = txtNameUser.Text;
                string passRecep = txtPass.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string accountID = "";

                //Tao tai khoan le tan
                string sqlNewAccRecep = $"exec procAddAccount '{accName}','{passRecep}','B'";
                data.changeData(sqlNewAccRecep);

                //Lay id tai khoan moi nhat
                string sqlLastAccount = "select TOP(1)accountid from account order by accountid desc ";
                DataTable tableLastAcc = data.readData(sqlLastAccount);
                if (tableLastAcc.Rows.Count > 0)
                {
                    foreach (DataRow acc in tableLastAcc.Rows)
                    {
                        accountID = acc["accountid"].ToString();
                        break;
                    }
                }

                //Them thong tin co ban cua le tan 
                string sqlInfoRecep = $@"exec procAddReceptionist 
                    N'{userName}', N'', '{email}', '{phoneNumber}', 0,
                    1, '{DateTimeConvert.convertSqlTime(DateTime.Today.ToString())}', '{accountID}'";
                data.changeData(sqlInfoRecep);
                MessageBox.Show("Tạo tài khoản thành công");
            }
            this.Hide();
            LoginMain loginMain = new LoginMain();
            loginMain.ShowDialog();
            this.Close();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterMain_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void RegisterMain_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void RegisterMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
