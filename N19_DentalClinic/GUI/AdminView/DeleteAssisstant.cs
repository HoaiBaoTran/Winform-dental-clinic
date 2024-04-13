using N19_DentalClinic.library;
using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.ReceptionistView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class DeleteAssisstant : Form
    {
        private string AssID;
        //Tham quyen role: 1 Quan li, 2 Le Tan, 3 Nha si
        private int role;
        //Kieu tuong tac: create, delete, update, view
        private string interactionKind;
        private Panel panelWrapper;
        DataInteraction data = new DataInteraction();
        public DeleteAssisstant(Panel panelWrapper, string assID, int role, string interaction)
        {
            InitializeComponent();
            AssID = assID;
            this.role = role;
            this.panelWrapper = panelWrapper;
            this.interactionKind = interaction;
        }

        private void DeleteAssisstant_Load(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnBack, "50657A", "ffffff");
            ColorMarker.ButtonColor(btnDelete, "FA3326", "ffffff");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new AssisstantFile(panelWrapper, role), panelWrapper);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(role==1)
            {
                string sqlUpdateAssiss = "update assisstant set able = " + 0
                                + " where AssiID = '" + AssID + "'";
                data.changeData(sqlUpdateAssiss);
                MessageBox.Show("Xóa thông tin phụ tá thành công");
                PanelInteraction.openForm(this, new AssisstantFile(panelWrapper, role), panelWrapper);
            }else
            {
                MessageBox.Show("Bạn không đủ thẩm quyền để xóa");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
