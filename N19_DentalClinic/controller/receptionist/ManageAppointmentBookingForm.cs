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
    public partial class ManageAppointmentBookingForm : Form
    {
        public ManageAppointmentBookingForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openManagePatientProfileForm()
        {
            this.Hide();
            ManagePatientProfileForm form = new ManagePatientProfileForm();
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


        private void btnPatientProfile_Click(object sender, EventArgs e)
        {
            openManagePatientProfileForm();
        }

        private void btnManageDentist_Click(object sender, EventArgs e)
        {
            openManageDentistForm();
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            openManageBillForm();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointmentForm form = new AddAppointmentForm();
            form.ShowDialog();
        }
    }

}
