using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.controller.receptionist
{
    public partial class ManageMedicineForm : Form
    {
        public ManageMedicineForm()
        {
            InitializeComponent();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            panelContent.Controls.Add(form);
            panelContent.Tag = form;

        }
    }
}
