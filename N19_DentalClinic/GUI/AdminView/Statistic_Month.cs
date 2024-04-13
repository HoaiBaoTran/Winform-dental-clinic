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
    public partial class Statistic_Month : UserControl
    {
        public Statistic_Month()
        {
            InitializeComponent();
        }

        private void Statistic_Month_Load(object sender, EventArgs e)
        {
            cbMonth1.Items.Add("Tháng 1");
            cbMonth1.Items.Add("Tháng 2");
            cbMonth1.Items.Add("Tháng 3");
            cbMonth1.Items.Add("Tháng 4");
            cbMonth1.Items.Add("Tháng 5");
            cbMonth1.Items.Add("Tháng 6");
            cbMonth1.Items.Add("Tháng 7");
            cbMonth1.Items.Add("Tháng 8");
            cbMonth1.Items.Add("Tháng 9");
            cbMonth1.Items.Add("Tháng 10");
            cbMonth1.Items.Add("Tháng 11");
            cbMonth1.Items.Add("Tháng 12");

            cbMonth2.Items.Add("Tháng 1");
            cbMonth2.Items.Add("Tháng 2");
            cbMonth2.Items.Add("Tháng 3");
            cbMonth2.Items.Add("Tháng 4");
            cbMonth2.Items.Add("Tháng 5");
            cbMonth2.Items.Add("Tháng 6");
            cbMonth2.Items.Add("Tháng 7");
            cbMonth2.Items.Add("Tháng 8");
            cbMonth2.Items.Add("Tháng 9");
            cbMonth2.Items.Add("Tháng 10");
            cbMonth2.Items.Add("Tháng 11");
            cbMonth2.Items.Add("Tháng 12");
        }
    }
}
