using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.DentistView
{
    public partial class Dentist : Form
    {
        public Dentist()
        {
            InitializeComponent();
        }

        private void Dentist_Load(object sender, EventArgs e)
        {
            btnCalendar.FlatAppearance.BorderSize = 0;
            btnPrescription.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");
            pnSidebar.BackColor = ColorTranslator.FromHtml("#323886");

         
            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");

            PanelInteraction.loadForm(new PatientFile(pnShowContent, 3), pnShowContent);
        }

        private void btnPatientProfile_Click(object sender, EventArgs e)
        {
            
            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");

            PanelInteraction.loadForm(new PatientFile(pnShowContent, 3), pnShowContent);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            
            ColorMarker.ButtonColor(btnCalendar, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");

            PanelInteraction.loadForm(new DentistSchedule(pnShowContent, 3), pnShowContent);
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            
            ColorMarker.ButtonColor(btnPrescription, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");

            PanelInteraction.loadForm(new DentistPrescription(pnShowContent, 3), pnShowContent);

        }
    }
}
