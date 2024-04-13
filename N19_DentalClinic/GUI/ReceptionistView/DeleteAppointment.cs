using N19_DentalClinic.library;
using N19_ProjectForm.DAO;
using N19_ProjectForm.GUI;
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

namespace N19_DentalClinic.GUI.ReceptionistView
{
    public partial class DeleteAppointment : Form
    {
        private string apId;
        DataInteraction data = new DataInteraction();
        public DeleteAppointment(string apId)
        {
            InitializeComponent();
            this.apId = apId;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlDelAp = "update appointment set able = 0 where apid = '" + apId + "'";
            data.changeData(sqlDelAp);
            MessageBox.Show("Xóa lịch hẹn thành công");
            this.Close();
        }

        private void DeleteAppointment_Load(object sender, EventArgs e)
        {
            ColorMarker.ButtonColor(btnBack, "50657A", "ffffff");
            ColorMarker.ButtonColor(btnDelete, "FA3326", "ffffff");
        }
    }
}
