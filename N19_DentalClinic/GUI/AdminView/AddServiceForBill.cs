using N19_DentalClinic.DAO;
using N19_DentalClinic.GUI.SupportView;
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
    public partial class AddServiceForBill : Form
    {

        private DataInteraction data = new DataInteraction();
        private string billId = string.Empty;

        public AddServiceForBill(string billId)
        {
            InitializeComponent();
            this.billId = billId;
        }

        private void handleAddService()
        {
            string serviceId = cbServiceId.Text;
            string quantity = tbQuantity.Text;
            if (!Int32.TryParse(quantity, out _))
            {
                MessageBox.Show("Số lượng phải là số nguyên");
                return;
            }
            if (int.Parse(quantity) < 0)
            {
                MessageBox.Show("Số lương không được âm");
                return;
            }
            string sql = $"Insert into bill_service(BilId, serviceID, quantity) values ('{billId}', '{serviceId}', " + quantity + ")";
            data.changeData(sql);
            MessageBox.Show("Thêm dịch vụ thành công");
            this.DialogResult = DialogResult.OK;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            handleAddService();
        }

        private void roundPictureBox2_Click(object sender, EventArgs e)
        {
            handleAddService();
        }

        private void AddServiceForBill_Load(object sender, EventArgs e)
        {
            string sql = "Select * from service";
            DataTable table = data.readData(sql);
            if (table.Rows.Count > 0)
            {
                cbServiceId.DataSource = table;
                cbServiceName.DataSource = table;
                cbPrice.DataSource = table;
                cbKindService.DataSource = table;

                cbServiceId.ValueMember = "serviceID";
                cbServiceName.ValueMember = "name";
                cbPrice.ValueMember = "price";
                cbKindService.ValueMember = "kindService";
            }
        }

        private void btnFindCode_Click(object sender, EventArgs e)
        {
            ServiceFileCopy fileCopy = new ServiceFileCopy();
            fileCopy.ShowDialog();  
        }
    }
}
