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
            string sqlFacload = "select  name from Faculty";
            DataTable tableFacLoad = data.readData(sqlFacload);
            foreach (DataRow rowFacLoad in tableFacLoad.Rows)
            {
                cbFaculty.Items.Add(rowFacLoad["name"].ToString());
            }
            if (interactionKind != "create")
            {
                string sql = "select * from dentist where DenID = '" + DenID + "'";
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
                        string sqlFac = "select * from Faculty where facId = '" + (string)row["FacID"] + "'";
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
            PanelInteraction.openForm(this, new DentistFile(panelWrapper, 2), panelWrapper);
        }

        private void btnCreateDentist_Click(object sender, EventArgs e)
        {
            if(role==1)
            {
                switch (interactionKind)
            {
                case "create":
                    // Xu li them thong tin
                    if (txtName.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên nha sĩ");
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
                    }else if (txtTitle.Text == "") 
                    {
                        MessageBox.Show("Vui lòng nhập học vị");
                    }else if(txtNation.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập quốc tịch");
                    }else if(cbFaculty.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn Khoa");
                    }else if(cbRank.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn bậc hạng");
                    }else if(txtSalary.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập lương");
                    }
                    else
                    {
                        string name = txtName.Text;
                        string birthday = txtBirthday.Text;
                        string email = txtEmail.Text;
                        string number = txtPhoneNumber.Text;
                        string phone = txtPhoneNumber.Text;
                        string address = txtAddress.Text;
                        int gender;
                        string title = txtTitle.Text;
                        string rank = cbRank.Text;
                        string nation = txtNation.Text;
                        int salary = 0;
                        if (Int32.TryParse(txtSalary.Text, out salary))
                        {
                            salary = Int32.Parse(txtSalary.Text);
                        }else
                        {
                            MessageBox.Show("Lương phải là số nguyên");
                            return;
                        }
                        if (rbMale.Checked)
                        {
                            gender = 1;
                        }
                        else
                        {
                            gender = 0;
                        }
                        string facID = "";
                        string sqlFal = "select * from Faculty where name = '" + cbFaculty.Text + "'";
                        DataTable tableFal = data.readData(sqlFal);
                        if(tableFal.Rows.Count > 0)
                        {
                            foreach(DataRow rowfal in tableFal.Rows)
                            {
                                    facID = rowfal["facId"].ToString();
                            }
                        }else
                        {
                            MessageBox.Show("Không tồn tại khoa này");
                            return;
                        }
                        string sqlAddDentist = "exec procAddDentist N'" 
                            + name 
                            + "', N'" + address 
                            + "', '" + email 
                            + "', '" + number 
                            + "', " + salary
                            + ", '" + facID
                            + "', '" + title
                            + "', '" + rank
                            + "', '" + nation
                            + "', " + gender 
                            + ", '" + DateTimeConvert.convertSqlTime(birthday.ToString()) 
                            + "'";
                        data.changeData(sqlAddDentist);
                        MessageBox.Show("Thêm nha sĩ mới thành công");
                        PanelInteraction.openForm(this, new DentistFile(panelWrapper, 2), panelWrapper);
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
                        string denID = txtDenID.Text;
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
                        //string sqlUpdatePatient = "update Patient set name = N'" + name + "', address = N'" + address +
                        //    "', email = '" + email + "', number = '" + number + "',gender = " + gender + ", birthday = '" +
                        //    DateTimeConvert.convertSqlTime(birthday.ToString()) + "' "
                        //    + "where patId = '" + patId + "'";
                        //data.changeData(sqlUpdatePatient);
                        //MessageBox.Show("Sửa thông tin bệnh nhân thành công");
                        //PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
                    }
                    break;
                default:
                    MessageBox.Show("Bạn chỉ thêm/sửa được thông tin ở phần thêm/sửa bệnh nhân");
                    break;
            }
            }else
            {
                MessageBox.Show("Không có ủy quyền để thêm bệnh nhân");
            }
        }
    }
}
