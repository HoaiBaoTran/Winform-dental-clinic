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
using N19_DentalClinic.library;
using N19_DentalClinic.controller.receptionist;
using N19_DentalClinic.GUI.ReceptionistView;


namespace N19_ProjectForm.GUI.ReceptionistView
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
            btnCreateAppointment.FlatAppearance.BorderSize = 0;
            btnDentistManagement.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            btnCreateBill.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            ColorMarker.ButtonColor(btnCreateAppointment, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
            panelSidebar.BackColor = ColorTranslator.FromHtml("#323886");

            PanelInteraction.loadForm(new ManageAppointment(pnShowContent), pnShowContent);
        }


        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageAppointment(pnShowContent), pnShowContent);
            ColorMarker.ButtonColor(btnCreateAppointment, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageBill(pnShowContent, 2), pnShowContent);
            ColorMarker.ButtonColor(btnCreateAppointment, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "DBAF09", "000000");
        }

        private void btnDentistManagement_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent), pnShowContent);
            ColorMarker.ButtonColor(btnCreateAppointment, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnDentistManagement, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
        }

        private void btnPatientProfile_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new PatientFile(pnShowContent, 2), pnShowContent);
            ColorMarker.ButtonColor(btnCreateAppointment, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
        }
    }
}
