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
    public partial class ManagePatientProfileForm : Form
    {
        public ManagePatientProfileForm()
        {
            InitializeComponent();
        }

        private void openManageAppointmentBookingForm()
        {
            this.Hide();
            ManageAppointmentBookingForm form = new ManageAppointmentBookingForm();
            form.ShowDialog();
            this.Close();
        }

        private void openManageDentistForm()
        {
            this.Hide();
            ManageDentistForm form = new ManageDentistForm();
            form.ShowDialog();
            this.Close();
        }

        private void openManageBillForm()
        {
            this.Hide();
            ManageBillForm form = new ManageBillForm();
            form.ShowDialog();
            this.Close();
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            openManageAppointmentBookingForm();
        }

        private void btnManageDentist_Click(object sender, EventArgs e)
        {
            openManageDentistForm();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            openManageBillForm();
        }
    }
}
