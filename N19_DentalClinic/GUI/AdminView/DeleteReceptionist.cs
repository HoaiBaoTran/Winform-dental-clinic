using N19_DentalClinic.library;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class DeleteReceptionist : Form
    {
        private string RecepId;
        //Tham quyen role: 1 Quan li, 2 Le Tan, 3 Nha si
        private int role;
        //Kieu tuong tac: create, delete, update, view
        private string interactionKind;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        public DeleteReceptionist(Panel panelWrapper, string RecepId, int role, string interaction)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.RecepId = RecepId;
            this.role = role;
            this.interactionKind = interaction;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new ReceptionistFile(panelWrapper, role), panelWrapper);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (role == 1)
            {
                string sqlUpdateRecep = "update receptionist set able = " + 0
                                + " where recepid = '" + RecepId + "'";
                data.changeData(sqlUpdateRecep);
                MessageBox.Show("Xóa thông tin lễ tân thành công");
                PanelInteraction.openForm(this, new ReceptionistFile(panelWrapper, role), panelWrapper);
            }
            else
            {
                MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
            }
        }

        private void DeleteReceptionist_Load(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnBack, "50657A", "ffffff");
            ColorMarker.ButtonColor(btnDelete, "FA3326", "ffffff");
        }
    }
}
