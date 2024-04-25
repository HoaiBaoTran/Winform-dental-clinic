
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
using N19_DentalClinic.GUI.AdminView;
using N19_DentalClinic.GUI.AccountView;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class Admin : Form
    {
        private int role;
        private string adminId = "AD00000001";
        DataInteraction data = new DataInteraction();
        public Admin()
        {
            InitializeComponent();
            this.role = 1;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //Doi ten 
            string sqlGetNameAdmin = $"select name from admin where adminid = '{adminId}'";
            DataTable tableGetNameAdmin = data.readData(sqlGetNameAdmin);
            if (tableGetNameAdmin.Rows.Count > 0)
            {
                foreach (DataRow row in tableGetNameAdmin.Rows)
                {
                    lbNameAdmin.Text = row["name"].ToString();
                    break;
                }
            }


            btnStatistics.FlatAppearance.BorderSize = 0;
            btnMaterialManagement.FlatAppearance.BorderSize = 0;
            btnServiceManagement.FlatAppearance.BorderSize = 0;
            btnManageAss.FlatAppearance.BorderSize = 0;
            btnManageDentist.FlatAppearance.BorderSize = 0;
            btnManageRecep.FlatAppearance.BorderSize = 0;
            btnPatFile.FlatAppearance.BorderSize = 0;
            btnManageBill.FlatAppearance.BorderSize = 0;


            this.BackColor = ColorTranslator.FromHtml("#323886");

            // Tai mau giao dien
            loadDefaultColorFunctionBtn();
            PanelInteraction.loadForm(new ManageService(pnShowContent, role), pnShowContent);
            ColorMarker.ButtonColor(btnServiceManagement, "DBAF09", "000000");

            pnSidebar.BackColor = ColorTranslator.FromHtml("#323886");
            ColorMarker.ButtonColor(btnManageAss, "E88ED9", "ffffff");
            ColorMarker.ButtonColor(btnManageDentist, "5B57F4", "ffffff");
            ColorMarker.ButtonColor(btnManageRecep, "3CBFF8", "ffffff");
        }

        //Mau mac dinh cac nut chuc nang
        private void loadDefaultColorFunctionBtn()
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatFile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");
        }

        private void btnServiceManagement_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");

            PanelInteraction.loadForm(new ManageService(pnShowContent, role), pnShowContent);
        }

        private void btnMaterialManagement_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");

            PanelInteraction.loadForm(new ManageMaterial(pnShowContent, role), pnShowContent);
            ColorMarker.ButtonColor(btnPatFile, "0918DB", "ffffff");
        }

        private void btnManageBill_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatFile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "DBAF09", "000000");

            PanelInteraction.loadForm(new ManageBill(pnShowContent, role), pnShowContent);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatFile, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");

            PanelInteraction.loadForm(new Report(), pnShowContent);
        }

        private void btnWorkCalendar_Click(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatFile, "0918DB", "ffffff");
        }
        private void btnPatFile_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new PatientFile(pnShowContent, role), pnShowContent);
            ColorMarker.ButtonColor(btnStatistics, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnPatFile, "DBAF09", "000000");
            ColorMarker.ButtonColor(btnMaterialManagement, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnManageBill, "0918DB", "ffffff");
            ColorMarker.ButtonColor(btnServiceManagement, "0918DB", "ffffff");
        }

        private void btnManageDentist_Click(object sender, EventArgs e)
        {
            loadDefaultColorFunctionBtn();
            PanelInteraction.loadForm(new DentistFile(pnShowContent, role), pnShowContent);
        }

        private void btnManageRecep_Click(object sender, EventArgs e)
        {
            loadDefaultColorFunctionBtn();
            PanelInteraction.loadForm(new ReceptionistFile(pnShowContent, role), pnShowContent);
        }

        private void btnManageAss_Click(object sender, EventArgs e)
        {
            loadDefaultColorFunctionBtn();
            PanelInteraction.loadForm(new AssisstantFile(pnShowContent, role), pnShowContent);
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            ConfirmToLogin confirmForm = new ConfirmToLogin(this, new LoginMain());
            confirmForm.ShowDialog();
        }
    }
}
