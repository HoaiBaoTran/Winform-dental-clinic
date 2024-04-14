using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.AdminView
{
    public partial class Statistic_Year : UserControl
    {
        public Statistic_Year()
        {
            InitializeComponent();

        }

        private void Statistic_Year_Load(object sender, EventArgs e)
        {
            
        }       
        
        public static int yearFrom = 2000;
        public static int yearTo = 2000;
        private void nmYear1_ValueChanged(object sender, EventArgs e)
        {
            if (nmYear1.Value >= 2000)
            {
                yearFrom = (int)nmYear1.Value;               
            }
            else { MessageBox.Show("Vui lòng nhập lại năm"); }
        }

        private void nmYear2_ValueChanged(object sender, EventArgs e)
        {
            if (nmYear2.Value >= 2000)
            {
                yearTo = (int)nmYear2.Value;
            }
            else { MessageBox.Show("Vui lòng nhập lại năm"); }
        }
    }
}
