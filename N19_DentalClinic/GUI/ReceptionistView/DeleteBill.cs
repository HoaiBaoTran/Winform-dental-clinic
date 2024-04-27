using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.AdminView;
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
    public partial class DeleteBill : Form
    {

        private int role;
        private Panel panelWrapper;
        private string billID;
        DataInteraction data = new DataInteraction();
        public DeleteBill(Panel panelWrapper, int role, string billID)
        {
            InitializeComponent();
            this.panelWrapper = panelWrapper;
            this.role = role;
            this.billID = billID;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PanelInteraction.openForm(this, new ManageBill(panelWrapper, role), panelWrapper);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDelBill = "update bill set able = 0 where bilid = '" + billID + "'";
            data.changeData(sqlDelBill);
            MessageBox.Show("Xóa hóa đơn thành công");
            PanelInteraction.openForm(this, new ManageBill(panelWrapper, role), panelWrapper);
        }
    }
}
