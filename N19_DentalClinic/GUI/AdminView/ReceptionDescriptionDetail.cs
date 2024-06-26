﻿using N19_DentalClinic.DTO;
using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class ReceptionDescriptionDetail : Form
    {
        private Panel panelWrapper;
        private string RecepID;
        DataInteraction data = new DataInteraction();
        private int role;
        private string interactionKind;
        public ReceptionDescriptionDetail(Panel panelWrapper, string recepId, int role, string interaction)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
            this.interactionKind = interaction;
            this.RecepID = recepId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ReceptionDescriptionDetail_Load(object sender, EventArgs e)
        {
            btnCreateRecep.BackColor = ColorTranslator.FromHtml("#" + "12DB4E");
            btnBack.BackColor = ColorTranslator.FromHtml("#" + "50657A");
            //Tai danh sach lễ tân len
            if (interactionKind != "create")
            {
                string sql = "select * from receptionist where able = 1 and recepid = '" + RecepID + "'";
                DataTable table = data.readData(sql);
                if (table.Columns.Count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        txtAddress.Text = (string)row["address"];
                        txtRecepId.Text = (string)row["recepid"];
                        txtEmail.Text = (string)row["email"];
                        txtName.Text = (string)row["name"];
                        txtPhoneNumber.Text = (string)row["phone_number"];
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
                        txtBirthday.Text = DateTimeConvert.convertDMY(row["birthday"].ToString());
                        if (role == 1)
                        {
                            txtSalary.Text = int.Parse(row["salary"].ToString()).ToString("#,##0");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin của lễ tân");
                }
            }
            switch (interactionKind)
            {
                case "create":
                    btnCreateRecep.Enabled = true;
                    btnCreateRecep.Text = "Tạo mới";
                    txtRecepId.ReadOnly = true;
                    txtName.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;
                    txtSalary.ReadOnly = false;


                    break;
                case "update":
                    // Xu li sua thong tin
                    btnCreateRecep.Enabled = true;
                    btnCreateRecep.Text = "Lưu";
                    txtRecepId.ReadOnly = true;
                    txtName.ReadOnly = false;
                    txtEmail.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtPhoneNumber.ReadOnly = false;
                    rbFemale.Enabled = true;
                    rbMale.Enabled = true;
                    btnCalendar.Enabled = true;
                    txtSalary.ReadOnly = false;

                    break;
                case "delete":
                    // Xu li xóa thong tin
                    btnCreateRecep.Enabled = false;
                    break;
                case "view":
                    // Xu li xem thong tin
                    btnCreateRecep.Enabled = false;
                    btnCreateRecep.Text = "Tạo mới";
                    txtRecepId.ReadOnly = false;
                    txtName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtAddress.ReadOnly = true;
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
            PanelInteraction.openForm(this, new ReceptionistFile(panelWrapper, role), panelWrapper);
        }

        private void btnCreateRecep_Click(object sender, EventArgs e)
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
                            errorMess = "Vui lòng nhập tên lễ tân";
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
                            string name = txtName.Text;
                            string birthday = txtBirthday.Text;
                            string email = txtEmail.Text;
                            string number = txtPhoneNumber.Text;
                            string address = txtAddress.Text;
                            int gender;
                            int salary = int.Parse(txtSalary.Text);
                            if (rbMale.Checked)
                            {
                                gender = 1;
                            }
                            else
                            {
                                gender = 0;
                            }
                            string sqlAddRecep = "exec procAddReceptionist N'"
                                + name
                                + "', N'" + address
                                + "', '" + email
                                + "', '" + number
                                + "', " + salary
                                + ", " + "'AD00000001'"
                                + ", " + gender
                                + ", '" + DateTimeConvert.convertSqlTimeDay(birthday.ToString())
                                + "'";
                            data.changeData(sqlAddRecep);
                            MessageBox.Show("Thêm lễ tân mới thành công");
                            PanelInteraction.openForm(this, new ReceptionistFile(panelWrapper, role), panelWrapper);
                        }
                        break;
                    case "update":
                        errorMess = "";
                        if (txtName.Text == "")
                        {
                            errorMess = "Vui lòng nhập tên lễ tân";
                        }
                        else if (txtBirthday.Text == "")
                        {
                            errorMess = "Vui lòng chọn năm sinh";
                        }
                        else if (DateTimeConvert.isFuture(txtBirthday.Text))
                        {
                            MessageBox.Show("Năm sinh không thể ở tương lai");
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
                            string name = txtName.Text;
                            string birthday = txtBirthday.Text;
                            string email = txtEmail.Text;
                            string number = txtPhoneNumber.Text;
                            string address = txtAddress.Text;
                            int gender;
                            int salary = int.Parse(txtSalary.Text);
                            if (rbMale.Checked)
                            {
                                gender = 1;
                            }
                            else
                            {
                                gender = 0;
                            }
                            string sqlUpdateReceptionist = $@"update receptionist set 
                                name = N'{name}',
                                address = N'{address}',
                                birthday = '{DateTimeConvert.convertSqlTimeDay(birthday)}',
                                phone_number = '{number}',
                                email = '{email}',
                                salary = {salary},
                                adminid = 'AD00000001',
                                gender = {gender}
                                where RecepId = '{RecepID}' and able = 1";
                            data.changeData(sqlUpdateReceptionist);
                            MessageBox.Show("Sửa thông tin lễ tân thành công");
                            PanelInteraction.openForm(this, new ReceptionistFile(panelWrapper, role), panelWrapper);
                        }
                        break;
                    default:
                        MessageBox.Show("Bạn chỉ thêm/sửa được thông tin ở phần thêm/sửa lễ tân");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Không có ủy quyền để thêm lễ tân");
            }
        }

        private void btnCalendar_Click_1(object sender, EventArgs e)
        {
            btnCalendar_Click(sender, e);
        }
    }
}
