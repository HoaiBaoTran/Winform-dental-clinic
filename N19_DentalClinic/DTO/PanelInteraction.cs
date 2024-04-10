using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.DAO
{
    internal class PanelInteraction
    {
        public static void loadForm(object Form, object Panel)
        {
            Form f = Form as Form;
            Panel p = Panel as Panel;
            if (p.Controls.Count > 0)
            {
                p.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);
            p.Tag = f;
            f.Show();
        }

        public static void openForm(Form oldForm, Form newForm, Panel currentPanel)
        {
            if (oldForm != null)
            {
                oldForm.Close();
            }
            oldForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            currentPanel.Controls.Add(newForm);
            currentPanel.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }
    }


}
