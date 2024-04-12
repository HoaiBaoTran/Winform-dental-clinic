using N19_DentalClinic.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_DentalClinic.GUI.DentistView
{
    public partial class AddMedicineRow : Form
    {
        DataInteraction data = new DataInteraction();

        public AddMedicineRow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMedicineRow_Load(object sender, EventArgs e)
        {
            comnboBoxLoad();
        }

        private void comnboBoxLoad()
        {
            string sql = @"select me.materialId, ma.name, ma.calUnit, ma.quantity 
                            from Medicine me
                            join Material ma on ma.materialID = me.materialID";
            DataTable table = data.readData(sql);
            cbMedicineId.DataSource = table;
            cbMedicineId.ValueMember = "materialId";

            cbMedicineName.DataSource = table;
            cbMedicineName.ValueMember = "name";

            cbCalUnit.DataSource = table;
            cbCalUnit.ValueMember = "calUnit";


        }


    }
}
