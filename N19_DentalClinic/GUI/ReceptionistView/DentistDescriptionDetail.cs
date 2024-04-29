using N19_DentalClinic.DAO;
using N19_DentalClinic.DTO;
using N19_DentalClinic.GUI.Work_schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class DentistDescriptionDetail : Form
    {
        private Panel panelWrapper;
        private string DenID;
        DataInteraction data = new DataInteraction();
        private int role;
        private string interactionKind;

        public DentistDescriptionDetail(Panel panelWrapper, string denID, int role, string interactionKind)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.DenID = denID;
            this.role = role;
            this.interactionKind = interactionKind;
        }

        private void DentistDescriptionDetail_Load(object sender, EventArgs e)
        {
            btnCreateDentist.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            btnBack.BackColor = ColorTranslator.FromHtml("#" + "50657A");
            string sqlFacload = "select name from Faculty where able = 1";
            DataTable tableFacLoad = data.readData(sqlFacload);
            foreach (DataRow rowFacLoad in tableFacLoad.Rows)
            {
                cbFaculty.Items.Add(rowFacLoad["name"].ToString());
            }
            //Tai danh sach nha si len
            if (interactionKind != "create")
            {
                string sql = "select * from dentist where able = 1 and DenID = '" + DenID + "'";
                DataTable table = data.readData(sql);
                if (table.Columns.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        txtAddress.Text = (string)row["address"];
                        txtDenID.Text = (string)row["denId"];
                        txtEmail.Text = (string)row["email"];
                        txtName.Text = (string)row["name"];
                        txtNation.Text = (string)row["nation"];
                        txtPhoneNumber.Text = (string)row["phone_number"];
                        txtTitle.Text = (string)row["title"];
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

                        // Lay Ten khoa cua nha si
                        string sqlFac = "select * from Faculty where able = 1 and facId = '" + (string)row["FacID"] + "'";
                        DataTable tableFac = data.readData(sqlFac);
                        if (tableFac.Columns.Count > 0)
                        {
                            foreach (DataRow rowFac in tableFac.Rows)
                            {
                                cbFaculty.Text = (string)rowFac["name"];
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Khoa của nha sĩ");
                        }
                        cbRank.Text = (string)row["rank"];
                        txtBirthday.Text = DateTimeConvert.convertDMY(row["birthday"].ToString());
                        if (role == 1)
                        {
                            if (interactionKind == "update")
                            {
                                txtSalary.Text = int.Parse(row["salary"].ToString()).ToString();
                            }
                            else
                            {
                                txtSalary.Text = int.Parse(row["salary"].ToString()).ToString("#,##0");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin của nha sĩ");
                }
            }

            switch (interactionKind)
            {
                case "create":
                    btnCreateDentist.Enabled = true;
                    btnCreateDentist.Text = "Tạo mới";
                    cbFaculty.Enabled = true;
                    txtDenID.ReadOnly = true;
                    cbRank.Enabled = true;
                    txtName.ReadOnly = false;
                    txtNation.ReadOnly = false;
                    txtTitle.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;
                    txtSalary.ReadOnly = false;
                    btnCalendarWork.Enabled = false;


                    break;
                case "update":
                    // Xu li sua thong tin
                    btnCreateDentist.Enabled = true;
                    btnCreateDentist.Text = "Lưu";
                    cbFaculty.Enabled = true;
                    txtDenID.ReadOnly = true;
                    cbRank.Enabled = true;
                    txtName.ReadOnly = false;
                    txtNation.ReadOnly = false;
                    txtTitle.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;
                    txtSalary.ReadOnly = false;
                    btnCalendarWork.Enabled = false;

                    break;
                case "delete":
                    // Xu li xóa thong tin
                    btnCreateDentist.Enabled = false;
                    break;
                case "view":
                    // Xu li xem thong tin
                    btnCreateDentist.Enabled = false;
                    btnCreateDentist.Text = "Tạo mới";
                    cbFaculty.Enabled = false;
                    txtDenID.ReadOnly = true;
                    cbRank.Enabled = false;
                    txtName.ReadOnly = true;
                    txtNation.ReadOnly = true;
                    txtTitle.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtPhoneNumber.ReadOnly = true;
                    rbFemale.Enabled = false;
                    rbMale.Enabled = false;
                    btnCalendar.Enabled = false;
                    txtSalary.ReadOnly = true;

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
            PanelInteraction.openForm(this, new DentistFile(panelWrapper, role), panelWrapper);
        }

        private void btnCreateDentist_Click(object sender, EventArgs e)
        {

            if (role == 1)
            {
                string errorMess = "";
                switch (interactionKind)
                {

                    case "create":
                        errorMess = "";

                        // Xu li them thong tin
                        if (txtName.Text == "")
                        {
                            errorMess = "Vui lòng nhập tên nha sĩ";
                        }
                        else if (txtBirthday.Text == "")
                        {
                            errorMess = "Vui lòng chọn năm sinh";
                        }
                        else if (DateTimeConvert.isFuture(txtBirthday.Text))
                        {
                            errorMess = "Năm sinh không thể ở tương lai";
                        }
                        else if (txtAddress.Text == "")
                        {
                            errorMess = "Vui lòng nhập địa chỉ";
                        }
                        else if (txtEmail.Text == "")
                        {
                            errorMess = "Vui lòng nhập email";
                        }
                        else if (CheckFieldInfo.checkEmail(txtEmail.Text) == false)
                        {
                            errorMess = "Email không hợp lệ";
                        }
                        else if (data.isExistEmailInsert(txtEmail.Text))
                        {
                            errorMess = "Đã tồn tại email";
                        }
                        else if (txtPhoneNumber.Text == "")
                        {
                            errorMess = "Vui lòng nhập số điện thoại";
                        }
                        else if (CheckFieldInfo.checkPhoneNumber(txtPhoneNumber.Text) == false)
                        {
                            errorMess = "Số điện thoại không hợp lệ";
                        }
                        else if (rbFemale.Checked == false && rbMale.Checked == false)
                        {
                            errorMess = "Vui lòng nhập chọn giới tính";
                        }
                        else if (txtTitle.Text == "")
                        {
                            errorMess = "Vui lòng nhập học vị";
                        }
                        else if (txtNation.Text == "")
                        {
                            errorMess = "Vui lòng nhập quốc tịch";
                        }
                        else if (cbFaculty.Text == "")
                        {
                            errorMess = "Vui lòng chọn Khoa";
                        }
                        else if (cbRank.Text == "")
                        {
                            errorMess = "Vui lòng chọn bậc hạng";
                        }
                        else if (txtSalary.Text == "")
                        {
                            errorMess = "Vui lòng nhập lương";
                        }
                        else if (CheckFieldInfo.checkInteger(txtSalary.Text) == false)
                        {
                            errorMess = "Lương phải là số nguyên";
                        }

                        if (errorMess != "")
                        {
                            MessageBox.Show(errorMess);
                        }
                        else
                        {
                            //them tai khoan nha si
                            int quantityAc = 0;
                            string sqlCountUser = "select count(*) as quantity from account";
                            DataTable tableCountUser = data.readData(sqlCountUser);
                            if (tableCountUser.Rows.Count > 0)
                            {
                                foreach (DataRow rowAccount in tableCountUser.Rows)
                                {
                                    quantityAc = int.Parse(rowAccount["quantity"].ToString());
                                    break;
                                }
                            }
                            quantityAc++;
                            string newUsername = "dentist" + quantityAc.ToString();
                            string newPassword = "123456";
                            string sqlAddAccountForDentist = $"exec procAddAccount '{newUsername}', '{newPassword}', 'C'";
                            data.changeData(sqlAddAccountForDentist);

                            string name = txtName.Text;
                            string birthday = txtBirthday.Text;
                            string email = txtEmail.Text;
                            string number = txtPhoneNumber.Text;
                            string address = txtAddress.Text;
                            int gender;
                            string title = txtTitle.Text;
                            string rank = cbRank.Text;
                            string nation = txtNation.Text;
                            int salary = int.Parse(txtSalary.Text);
                            if (rbMale.Checked)
                            {
                                gender = 1;
                            }
                            else
                            {
                                gender = 0;
                            }
                            string facID = "";
                            string sqlFal = "select * from Faculty where able = 1 and name = N'" + cbFaculty.Text + "'";
                            DataTable tableFal = data.readData(sqlFal);
                            if (tableFal.Rows.Count > 0)
                            {
                                foreach (DataRow rowfal in tableFal.Rows)
                                {
                                    facID = rowfal["facId"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại khoa này");
                                return;
                            }
                            string lenZeroInNewAcc = "00000000".Substring(0, 8 - quantityAc.ToString().Length);
                            string sqlAddDentist = "exec procAddDentist N'"
                                + name
                                + "', N'" + address
                                + "', '" + email
                                + "', '" + number
                                + "', " + salary
                                + ", '" + facID
                                + "', N'" + title
                                + "', '" + rank
                                + "', N'" + nation
                                + "', " + gender
                                + ", '" + DateTimeConvert.convertSqlTimeDay(birthday.ToString())
                                + "', '" + "AC" + lenZeroInNewAcc + quantityAc.ToString() + "'";
                            data.changeData(sqlAddDentist);
                            MessageBox.Show("Thêm nha sĩ mới thành công");
                            PanelInteraction.openForm(this, new DentistFile(panelWrapper, role), panelWrapper);
                        }
                        break;
                    case "update":
                        string oldEmail = "";
                        string sqlEmail = "select email from dentist where denid = '" + DenID + "'";
                        DataTable tableEmail = data.readData(sqlEmail);
                        if (tableEmail.Rows.Count > 0)
                        {
                            foreach (DataRow email in tableEmail.Rows)
                            {
                                oldEmail = email["email"].ToString();
                            }
                        }
                        errorMess = "";
                        if (txtName.Text == "")
                        {
                            errorMess = "Vui lòng nhập tên nha sĩ";
                        }
                        else if (txtBirthday.Text == "")
                        {
                            errorMess = "Vui lòng chọn năm sinh";
                        }
                        else if (DateTimeConvert.isFuture(txtBirthday.Text))
                        {
                            errorMess = "Năm sinh không thể ở tương lai";
                        }
                        else if (txtAddress.Text == "")
                        {
                            errorMess = "Vui lòng nhập địa chỉ";
                        }
                        else if (txtEmail.Text == "")
                        {
                            errorMess = "Vui lòng nhập email";
                        }
                        else if (CheckFieldInfo.checkEmail(txtEmail.Text) == false)
                        {
                            errorMess = "Email không hợp lệ";
                        }
                        else if (data.isExistEmailUpdate(txtEmail.Text, oldEmail))
                        {
                            errorMess = "Đã tồn tại email";
                        }
                        else if (txtPhoneNumber.Text == "")
                        {
                            errorMess = "Vui lòng nhập số điện thoại";
                        }
                        else if (CheckFieldInfo.checkPhoneNumber(txtPhoneNumber.Text) == false)
                        {
                            errorMess = "Số điện thoại không hợp lệ";
                        }
                        else if (rbFemale.Checked == false && rbMale.Checked == false)
                        {
                            errorMess = "Vui lòng nhập chọn giới tính";
                        }
                        else if (txtTitle.Text == "")
                        {
                            errorMess = "Vui lòng nhập học vị";
                        }
                        else if (txtNation.Text == "")
                        {
                            errorMess = "Vui lòng nhập quốc tịch";
                        }
                        else if (cbFaculty.Text == "")
                        {
                            errorMess = "Vui lòng chọn Khoa";
                        }
                        else if (cbRank.Text == "")
                        {
                            errorMess = "Vui lòng chọn bậc hạng";
                        }
                        else if (txtSalary.Text == "")
                        {
                            errorMess = "Vui lòng nhập lương";
                        }
                        else if (CheckFieldInfo.checkInteger(txtSalary.Text) == false)
                        {
                            errorMess = "Lương phải là số nguyên";
                        }

                        if (errorMess != "")
                        {
                            MessageBox.Show(errorMess);
                            return;
                        }
                        else
                        {
                            string name = txtName.Text;
                            string birthday = txtBirthday.Text;
                            string email = txtEmail.Text;
                            string number = txtPhoneNumber.Text;
                            string address = txtAddress.Text;
                            int gender;
                            string title = txtTitle.Text;
                            string rank = cbRank.Text;
                            string nation = txtNation.Text;
                            int salary = salary = int.Parse(txtSalary.Text);
                            if (rbMale.Checked)
                            {
                                gender = 1;
                            }
                            else
                            {
                                gender = 0;
                            }
                            string facID = "";
                            string sqlFal = "select * from Faculty where able = 1 and name = N'" + cbFaculty.Text + "'";
                            DataTable tableFal = data.readData(sqlFal);
                            if (tableFal.Rows.Count > 0)
                            {
                                foreach (DataRow rowfal in tableFal.Rows)
                                {
                                    facID = rowfal["facId"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại khoa này");
                                return;
                            }
                            string sqlUpdateDentist = $@"update dentist set 
                                name = N'{name}',
                                address = N'{address}',
                                birthday = '{DateTimeConvert.convertSqlTimeDay(birthday.ToString())}',
                                phone_number = '{number}',
                                email = '{email}',
                                salary = {salary},
                                facid = '{facID}',
                                nation = N'{nation}',
                                gender = {gender},
                                rank = '{rank}',
                                title = N'{title}'
                                where denid = '{DenID}' and able = 1";
                            data.changeData(sqlUpdateDentist);
                            MessageBox.Show("Sửa thông tin nha sĩ thành công");
                            PanelInteraction.openForm(this, new DentistFile(panelWrapper, role), panelWrapper);
                        }
                        break;
                    default:
                        MessageBox.Show("Bạn chỉ thêm/sửa được thông tin ở phần thêm/sửa nha sĩ");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không có ủy quyền để thêm nha sĩ");
            }
        }

        private void btnCalendarWork_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new MainSchedule(DenID, panelWrapper,role), panelWrapper);
        }
    }
}
