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
            btnPatientFiles.FlatAppearance.BorderSize = 0;
            btnCreateBill.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            ColorMarker.ButtonColor(btnCreateAppointment, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnDentistManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientFiles, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCreateBill, "0918DB", "ffffff");
            panelSidebar.BackColor = ColorTranslator.FromHtml("#323886");
        }


        private void btnPatientFile_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent), pnShowContent);
        }

        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new ManageAppointment(pnShowContent), pnShowContent);
        }

        private void btnPatientFiles_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent), pnShowContent);
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent), pnShowContent);
        }
    }
}
