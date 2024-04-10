using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI.ReceptionistView
{
    public partial class DentistDescriptionDetail : Form
    {
        private Panel panelWrapper;
        private string DenID;
        DataInteraction data = new DataInteraction();
        public DentistDescriptionDetail(Panel panelWrapper, string denID)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            DenID = denID;
        }

        private void DentistDescriptionDetail_Load(object sender, EventArgs e)
        {
            string sql = "select * from dentist where DenID = '" + DenID + "'";
            DataTable table = data.readData(sql);
            if(table.Columns.Count > 0 )
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
                    } else
                    {
                        rbFemale.Checked = true;
                        rbMale.Checked = false;
                    }

                    // Lay Ten khoa cua nha si
                    string sqlFac = "select * from Faculty where facId = '" + (string)row["FacID"] + "'";
                    DataTable tableFac = data.readData(sqlFac);
                    if(tableFac.Columns.Count > 0 )
                    {
                        foreach (DataRow rowFac in tableFac.Rows)
                        {
                            cbFaculty.Text = (string)rowFac["name"]; 
                        }
                    }else
                    {
                        MessageBox.Show("Không tìm thấy Khoa của nha sĩ");
                    }
                    cbRank.Text = (string)row["rank"];
                    txtBirthday.Text = DateTimeConvert.convertDMY(row["birthday"].ToString());
                }
            }else
            {
                MessageBox.Show("Không tìm thấy thông tin của nha sĩ");
            }
        }

    }
}
