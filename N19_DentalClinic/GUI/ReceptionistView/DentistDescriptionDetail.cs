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
            this.panelWrapper = panelWrapper;
            this.DenID = denID;
            this.role = role;
            this.interactionKind = interactionKind;
        }
        public DentistDescriptionDetail(Panel panelWrapper, string denID)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            DenID = denID;
        }

        private void DentistDescriptionDetail_Load(object sender, EventArgs e)
        {

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
                    txtDenID.Enabled = false;
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


                    break;
                case "update":
                    // Xu li sua thong tin
                    btnCreateDentist.Enabled = true;
                    btnCreateDentist.Text = "Lưu";
                    cbFaculty.Enabled = true;
                    txtDenID.Enabled = false;
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
                    txtDenID.Enabled = false;
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
    }
}
