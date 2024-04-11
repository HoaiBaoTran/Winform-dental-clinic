using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using N19_DentalClinic.library;

namespace N19_ProjectForm.GUI
{
    public partial class DeletePatient : Form
    {
        //Tham quyen role: 1 Quan li, 2 Le Tan, 3 Nha si
        private int role;
        //Kieu tuong tac: create, delete, update, view
        private string interactionKind;
        private Panel panelWrapper;
        private string patID;
        DataInteraction data = new DataInteraction();
        public DeletePatient(Panel panelWrapper, string patID, int role, string interactionKind)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.patID = patID;
            this.role = role;
            this.interactionKind = interactionKind;
        }

        private void DeletePatient_Load(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnBack, "50657A", "ffffff");
            ColorMarker.ButtonColor(btnDelete, "FA3326", "ffffff");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlUpdatePatient = "update Patient set able = " + 0
                            + "where patId = '" + patID + "'";
            data.changeData(sqlUpdatePatient);
            MessageBox.Show("Xóa thông tin bệnh nhân thành công");
            PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new PatientFile(panelWrapper, 2), panelWrapper);
        }
    }
}
