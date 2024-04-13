﻿using N19_DentalClinic.DAO;
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
    public partial class AddService : Form
    {

        private DataInteraction data = new DataInteraction();
        private string serviceId = string.Empty;
        private string serviceName = string.Empty;
        private string price = string.Empty;
        private string calUnit = string.Empty;
        private string note = string.Empty;
        private bool isEdit = false;

        public AddService()
        {
            InitializeComponent();
        }

        public AddService(string serviceId, string serviceName, string price, string calUnit, string note)
        {
            InitializeComponent();
            this.serviceId = serviceId;
            this.serviceName = serviceName;
            this.price = price;
            this.calUnit = calUnit;
            this.note = note;

            isEdit = true;
        }

        private void handleAddService()
        {
            string serviceName = tbServiceName.Text;
            string calUnit = tbCalUnit.Text;
            string price = tbPrice.Text;
            string note = tbNote.Text;

            if (!isEdit)
            {

                string sql = @$"insert into Service(serviceID, name, price, CalUnit, quantity, note) values
                               (dbo.autoSeid(), N'{serviceName}', " + price + $", N'{calUnit}', 1, N'{note}')";
                data.changeData(sql);
                MessageBox.Show("Thêm dịch vụ thành công");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string sql = @$"update Service
                            set name = N'{serviceName}', price = " + price + $@", CalUnit = N'{calUnit}', quantity = 1, note = N'{note}'
                            where serviceID = '{serviceId}'";
                data.changeData(sql);
                MessageBox.Show("Cập nhật dịch vụ thành công");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            handleAddService();
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                btnAddService.Text = "Cập nhật";
                tbServiceId.Text = serviceId;
                tbServiceName.Text = serviceName;
                tbPrice.Text = price;
                tbNote.Text = note;
                tbCalUnit.Text = calUnit;
                tbServiceId.ReadOnly = true;
            }
            else
            {
                tbServiceId.Enabled = false;
                tbServiceId.BackColor = Color.Gray;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            handleAddService();
        }
    }
}
