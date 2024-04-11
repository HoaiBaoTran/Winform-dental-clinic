using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI
{
    public partial class PatientDecriptionDetail : Form
    {
        //Tham quyen role: 1 Quan li, 2 Le Tan, 3 Nha si
        private int role;
        //Kieu tuong tac: create, delete, update, view
        private string interactionKind;
        private Panel panelWrapper;
        private string patID;
        DataInteraction data = new DataInteraction();
        public PatientDecriptionDetail(Panel panelWrapper, string patID, int role,string interactionKind)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.patID = patID;
            this.role = role;
            this.interactionKind = interactionKind;
        }

        private void PatientDecriptionDetail_Load(object sender, EventArgs e)
        {
            if(interactionKind != "create")
            {

                string sql = "select * from patient where patID = '" + patID + "'";
                DataTable table = data.readData(sql);
                if (table.Columns.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        txtAddress.Text = (string)row["address"];
                        txtPatID.Text = (string)row["patID"];
                        txtEmail.Text = (string)row["email"];
                        txtName.Text = (string)row["name"];
                        txtPhoneNumber.Text = (string)row["number"];
                        if ((bool)row["gender"] == true)
                        {
                            rbFemale.Checked = false;
                            rbMale.Checked = true;
                        }
                        else
                        {
                            rbFemale.Checked = true;
                            rbMale.Checked = false;
                        }
                        string DenOfPat = "";
                        DataTable tableDen = data.getDataTableDenByPat("GetDentistByPatID", patID);
                        if(tableDen.Columns.Count > 0 )
                        {
                            foreach(DataRow rowden  in tableDen.Rows)
                            {
                                DenOfPat = rowden["name"].ToString();
                            }
                        }

                        txtDenOfPat.Text = DenOfPat;
                        txtBirthday.Text = DateTimeConvert.convertDMY(row["birthday"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin của bệnh nhân");
                }
            }
            // Doi nut tao moi khi them sua xoa
            switch (interactionKind)
            {
                case "create":
                    btnCreatePatient.Enabled = true;
                    btnCreatePatient.Text = "Tạo mới";
                    txtAddress.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;


                    break;
                case "update":
                    // Xu li sua thong tin
                    btnCreatePatient.Enabled = true;
                    btnCreatePatient.Text = "Lưu";
                    txtAddress.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtName.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;

                    break;
                case "delete":
                    // Xu li xóa thong tin
                    btnCreatePatient.Enabled = false;
                    break;
                case "view":
                    // Xu li xem thong tin
                    btnCreatePatient.Enabled = false;
                    break;
            }
        }

        private void btnCreatePatient_Click(object sender, EventArgs e)
        {
            switch (interactionKind)
            {
                case "create":
                    // Xu li them thong tin
                    if(txtName.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên bệnh nhân");
                    }
                    else if(txtBirthday.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn năm sinh");
                    }else if(txtAddress.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ");
                    }
                    else if(txtEmail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập email");
                    }
                    else if (txtPhoneNumber.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại");
                    }
                    else if(rbFemale.Checked == false && rbMale.Checked == false) 
                    {
                        MessageBox.Show("Vui lòng nhập chọn giới tính");
                    }else
                    {
                        string name = txtName.Text;
                        string birthday = txtBirthday.Text;
                        string email = txtEmail.Text;
                        string number = txtPhoneNumber.Text;
                        string phone = txtPhoneNumber.Text;
                        string address = txtAddress.Text;
                        int gender;
                        if(rbMale.Checked)
                        {
                            gender = 1;
                        }else
                        {
                            gender = 0;
                        }
                        string sqlAddPatient = "exec procAddPatient N'" + name + "', N'" + address + "', '" + email + "', '" + number + "', " + gender + ", '" + DateTimeConvert.convertSqlTime(birthday.ToString()) + "'"; 
                        data.changeData(sqlAddPatient);
                        MessageBox.Show("Thêm bệnh nhân mới thành công");
                        PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
                    }
                    break;
                case "update":
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên bệnh nhân");
                    }
                    else if (txtBirthday.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn năm sinh");
                    }
                    else if (txtAddress.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập địa chỉ");
                    }
                    else if (txtEmail.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập email");
                    }
                    else if (txtPhoneNumber.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập số điện thoại");
                    }
                    else if (rbFemale.Checked == false && rbMale.Checked == false)
                    {
                        MessageBox.Show("Vui lòng nhập chọn giới tính");
                    }
                    else
                    {
                        string patId = txtPatID.Text;
                        string name = txtName.Text;
                        string birthday = txtBirthday.Text;
                        string email = txtEmail.Text;
                        string number = txtPhoneNumber.Text;
                        string phone = txtPhoneNumber.Text;
                        string address = txtAddress.Text;
                        int gender;
                        if (rbMale.Checked)
                        {
                            gender = 1;
                        }
                        else
                        {
                            gender = 0;
                        }
                        string sqlUpdatePatient = "update Patient set name = N'" + name + "', address = N'" + address +
                            "', email = '" + email + "', number = '" + number + "',gender = " + gender + ", birthday = '" +
                            DateTimeConvert.convertSqlTime(birthday.ToString()) + "' "
                            + "where patId = '" + patId + "'";
                        data.changeData(sqlUpdatePatient);
                        MessageBox.Show("Sửa thông tin bệnh nhân thành công");
                        PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
                    }
                    break;
                default:
                    MessageBox.Show("Bạn chỉ thêm/sửa được thông tin ở phần thêm/sửa bệnh nhân");
                    break;
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendar calendarF = new Calendar();
            calendarF.ShowDialog();
            DateTime dayChoose = calendarF.GetDateSelector();
            txtBirthday.Text = DateTimeConvert.convertDMY(dayChoose.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
        }
    }
}
