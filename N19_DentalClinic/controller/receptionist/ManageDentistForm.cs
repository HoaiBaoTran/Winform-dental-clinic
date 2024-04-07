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
    public partial class ManageDentistForm : Form
    {
        public ManageDentistForm()
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

        private void openManagePatientProfileForm()
        {
            this.Hide();
            ManagePatientProfileForm form = new ManagePatientProfileForm();
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

        private void btnPatientProfile_Click(object sender, EventArgs e)
        {
            openManagePatientProfileForm();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            openManageBillForm();
        }
    }
}
