using N19_ProjectForm.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.GUI.ReceptionistView
{
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {
        }


        private void btnPatientFile_Click(object sender, EventArgs e)
        {
            PanelInteraction.loadForm(new DentistFile(pnShowContent), pnShowContent);
        }
    }
}
