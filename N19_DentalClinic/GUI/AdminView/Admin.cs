
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.library;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class Admin : Form
    {
        private int role;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();

        public Admin()
        {
            InitializeComponent();
        }

        public Admin(int role)
        {
            InitializeComponent();
            this.role = role;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            btnStatistics.FlatAppearance.BorderSize = 0;
            btnWorkCalendar.FlatAppearance.BorderSize = 0;
            btnMaterialManagement.FlatAppearance.BorderSize = 0;
            btnServiceManagement.FlatAppearance.BorderSize = 0;
            btnManageAss.FlatAppearance.BorderSize = 0;
            btnManageDentist.FlatAppearance.BorderSize = 0;
            btnManageRecep.FlatAppearance.BorderSize = 0;

            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnWorkCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "DBAF09", "000000");
            PanelInteraction.loadForm(new ManageService(pnShowContent, 3), pnShowContent);
            pnSidebar.BackColor = ColorTranslator.FromHtml("#323886");
            ColorMarker.ButtonColor(btnManageAss, "E88ED9", "ffffff");
            ColorMarker.ButtonColor(btnManageDentist, "5B57F4", "ffffff");
            ColorMarker.ButtonColor(btnManageRecep, "3CBFF8", "ffffff");
        }

        private void btnMaterialManagement_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnWorkCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");

            PanelInteraction.loadForm(new ManageMaterial(pnShowContent, 3), pnShowContent);
        }

        private void btnServiceManagement_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnWorkCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "DBAF09", "000000");

            PanelInteraction.loadForm(new ManageService(pnShowContent, 3), pnShowContent);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnWorkCalendar, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
        }

        private void btnWorkCalendar_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnWorkCalendar, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
        }

        private void btnManageDentist_Click(object sender, EventArgs e)
        {
            //PanelInteraction.loadForm(new DentistFile(pnShowContent, role), pnShowContent);
        }

        private void btnManageRecep_Click(object sender, EventArgs e)
        {

        }

        private void btnManageAss_Click(object sender, EventArgs e)
        {

        }
    }
}
