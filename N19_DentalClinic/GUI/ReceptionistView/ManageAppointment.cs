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
    public partial class ManageAppointment : Form
    {
        Panel panel;
        public ManageAppointment(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
        }
    }
}
