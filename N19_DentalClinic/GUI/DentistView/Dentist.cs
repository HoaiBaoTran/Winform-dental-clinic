using N19_ProjectForm.DTO.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI.DentistView
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
            btnPatientFiles.FlatAppearance.BorderSize = 0;
            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            ColorMaker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMaker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMaker.ButtonColor(btnPatientFiles, "0918DB", "ffffff");
            pnSidebar.BackColor = ColorTranslator.FromHtml("#323886");
        }

        private void btnPatientFiles_Click(object sender, EventArgs e)
        {
            ColorMaker.ButtonColor(btnPatientFiles, "DBAF09", "000000");
            ColorMaker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMaker.ButtonColor(btnCalendar, "0918DB", "ffffff");
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ColorMaker.ButtonColor(btnCalendar, "DBAF09", "000000");
            ColorMaker.ButtonColor(btnPrescription, "0918DB", "ffffff");
            ColorMaker.ButtonColor(btnPatientFiles, "0918DB", "ffffff");
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            ColorMaker.ButtonColor(btnPrescription, "DBAF09", "000000");
            ColorMaker.ButtonColor(btnCalendar, "0918DB", "ffffff");
            ColorMaker.ButtonColor(btnPatientFiles, "0918DB", "ffffff");
        }
    }
}
