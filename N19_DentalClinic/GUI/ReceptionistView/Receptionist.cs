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
using N19_DentalClinic.library;
using N19_DentalClinic.controller.receptionist;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.GUI.AccountView;
using N19_DentalClinic.GUI.AdminView;


namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class Receptionist : Form
    {
        private int role;
        private string recepId;
        DataInteraction data = new DataInteraction();
        public Receptionist(string recepId)
        {
            InitializeComponent();
            this.role = 2;
            this.recepId = recepId;
        }

        public void Receptionist_Load(object sender, EventArgs e)
        {
            //Doi ten 
            string sqlGetNameRecep = $"select name from receptionist where recepid = '{recepId}'";
            DataTable tableGetNameRecep = data.readData(sqlGetNameRecep);
            if (tableGetNameRecep.Rows.Count > 0)
            {
                foreach (DataRow row in tableGetNameRecep.Rows)
                {
                    lbNameReceptionist.Text = row["name"].ToString();
                    break;
                }
            }

            btnCreateAppointment.FlatAppearance.BorderSize = 0;
            btnDentistManagement.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            btnCreateBill.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnCreateAppointment, "DBAF09", "000000");
            panelSidebar.BackColor = ColorTranslator.FromHtml("#323886");

            PanelInteraction.loadForm(new ManageAppointment(role), pnShowContent);
        }

        private void defaultColorButtonInSideBar()
        {
            ColorMarker.ButtonColor(btnCreateAppointment, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAssisstantManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnSerivce, "0918DB", "ffffff");

        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageAppointment(role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnCreateAppointment, "DBAF09", "000000");
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageBill(pnShowContent, role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnCreateBill, "DBAF09", "000000");
        }

        private void btnDentistManagement_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent, role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnDentistManagement, "DBAF09", "000000");
        }

        public void btnPatientProfile_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new PatientFile(pnShowContent, role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            ConfirmToLogin confirmForm = new ConfirmToLogin(this, new LoginMain());
            confirmForm.ShowDialog();
        }

        private void btnAssisstantManagement_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new AssisstantFile(pnShowContent, role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnAssisstantManagement, "DBAF09", "000000");
        }

        private void btnSerivce_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageService(pnShowContent, role), pnShowContent);
            defaultColorButtonInSideBar();
            ColorMarker.ButtonColor(btnSerivce, "DBAF09", "000000");
        }
    }
}
