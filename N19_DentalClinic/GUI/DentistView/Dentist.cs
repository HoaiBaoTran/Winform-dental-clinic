using N19_DentalClinic.controller;
using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.AccountView;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.GUI.Work_schedule;
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
        private int role;
        private string denId;
        DataInteraction data = new DataInteraction();
        public Dentist(string denId)
        {
            InitializeComponent();
            this.role = 3;
            this.denId = denId;
        }

        private void Dentist_Load(object sender, EventArgs e)
        {

            //Doi ten 
            string sqlGetNameDentist = $"select name from dentist where denid = '{denId}'";
            DataTable tableGetNameDentist = data.readData(sqlGetNameDentist);
            if (tableGetNameDentist.Rows.Count > 0)
            {
                foreach (DataRow row in tableGetNameDentist.Rows)
                {
                    lbNameDentist.Text = row["name"].ToString();
                    break;
                }
            }


            btnCalendar.FlatAppearance.BorderSize = 0;
            btnPrescription.FlatAppearance.BorderSize = 0;
            btnPatientProfile.FlatAppearance.BorderSize = 0;
            btnAppoitmentForDentist.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");
            pnSidebar.BackColor = ColorTranslator.FromHtml("#323886");


            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAppoitmentForDentist, "0918DB", "ffffff");

            PanelInteraction.loadForm(new PatientFile(pnShowContent, role), pnShowContent);
        }

        private void btnPatientProfile_Click(object sender, EventArgs e)
        {

            ColorMarker.ButtonColor(btnPatientProfile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAppoitmentForDentist, "0918DB", "ffffff");

            PanelInteraction.loadForm(new PatientFile(pnShowContent, role), pnShowContent);
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {

            ColorMarker.ButtonColor(btnCalendar, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAppoitmentForDentist, "0918DB", "ffffff");

            PanelInteraction.loadForm(new MainSchedule(denId, pnShowContent, role), pnShowContent);
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {

            ColorMarker.ButtonColor(btnPrescription, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAppoitmentForDentist, "0918DB", "ffffff");

            PanelInteraction.loadForm(new DentistPrescription(pnShowContent, role), pnShowContent);

        }

        private void btnAppoitmentForDentist_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatientProfile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnAppoitmentForDentist, "DBAF09", "000000");

            PanelInteraction.loadForm(new AppointmentForDentist(pnShowContent, denId, role, "view"), pnShowContent);
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            ConfirmToLogin confirmForm = new ConfirmToLogin(this, new LoginMain());
            confirmForm.ShowDialog();
        }
    }
}
