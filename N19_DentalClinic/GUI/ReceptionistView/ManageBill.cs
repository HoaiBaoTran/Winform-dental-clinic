using N19_DentalClinic.controller.receptionist;
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
    public partial class ManageBill : Form
    {

        Panel panel;
        int role;
        public ManageBill(Panel panel, int role)
        {
            InitializeComponent();
            this.panel = panel;
            this.role = role;
        }

        private void btnAddDentist_Click(object sender, EventArgs e)
        {
            AddBillForm addBillForm = new AddBillForm();
            addBillForm.ShowDialog();
        }

        private void ManageBill_Load(object sender, EventArgs e)
        {

        }
    }
}
