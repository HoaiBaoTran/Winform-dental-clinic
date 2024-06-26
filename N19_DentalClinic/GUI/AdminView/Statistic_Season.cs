﻿using System;
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
    public partial class Statistic_Season : UserControl
    {
        public static int quarterFrom = 1;
        public static int quarterTo = 1;
        public Statistic_Season()
        {
            InitializeComponent();
        }

        private void Statistic_Season_Load(object sender, EventArgs e)
        {
            cbSea1.Items.Add("Quý 1");
            cbSea1.Items.Add("Quý 2");
            cbSea1.Items.Add("Quý 3");
            cbSea1.Items.Add("Quý 4");

            cbSea2.Items.Add("Quý 1");
            cbSea2.Items.Add("Quý 2");
            cbSea2.Items.Add("Quý 3");
            cbSea2.Items.Add("Quý 4");

        }
        
        private void cbSea1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quarterFrom = (int)cbSea1.SelectedIndex + 1;
        }

        private void cbSea2_SelectedIndexChanged(object sender, EventArgs e)
        {
            quarterTo = (int)cbSea2.SelectedIndex + 1;
        }
    }
}
