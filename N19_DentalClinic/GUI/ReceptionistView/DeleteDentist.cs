using N19_DentalClinic.library;
using N19_ProjectForm.DAO;
using N19_ProjectForm.GUI;
using N19_ProjectForm.GUI.ReceptionistView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class DeleteDentist : Form
    {
        //Tham quyen role: 1 Quan li, 2 Le Tan, 3 Nha si
        private int role;
        //Kieu tuong tac: create, delete, update, view
        private string interactionKind;
        private Panel panelWrapper;
        private string denId;
        DataInteraction data = new DataInteraction();
        public DeleteDentist(Panel panelWrapper, string denId, int role, string interactionKind)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.denId = denId;
            this.role = role;
            this.interactionKind = interactionKind;
        }

        private void DeleteDentist_Load(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnBack, "50657A", "ffffff");
            ColorMarker.ButtonColor(btnDelete, "FA3326", "ffffff");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(role == 1)
            {
                string sqlUpdateDentist = "update dentist set able = " + 0
                                + " where denid = '" + denId + "'";
                data.changeData(sqlUpdateDentist);
                MessageBox.Show("Xóa thông tin nha sĩ thành công");
                PanelInteraction.openForm(this, new DentistFile(panelWrapper, 2), panelWrapper);

            }else
            {
                MessageBox.Show("Bạn không đủ uy quyền để xóa");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new DentistFile(panelWrapper, 2), panelWrapper);
        }
    }
}
