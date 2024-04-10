using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N19_ProjectForm.DAO
{
    class EclipseControl : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );
        private Control cntrl;
        private int cornerRadius = 30;

        public Control TargetControl
        {
            get { return cntrl; }
            set
            {
                cntrl = value;
                cntrl.SizeChanged += (sender, e) => cntrl.Region = getCntrlRegion(cntrl);
            }
        }

        public Region getCntrlRegion(Control cntrl)
        {
            Region reg = new Region();
            if (cntrl != null)
            {
                reg = getRegion(cntrl);
                cntrl.Region = reg;
            }
            return cntrl.Region;
        }

        public Region getRegion(Control cntrl)
        {
            int x = 0;
            int y = 0;
            int width = 0;
            int height = 0;
            if (cntrl != null)
            {
                width = cntrl.Width;
                height = cntrl.Height;
            }
            return Region.FromHrgn(CreateRoundRectRgn(x, y, width, height, cornerRadius, cornerRadius));
        }

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                if (cntrl != null)
                {
                    cntrl.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cntrl.Width, cntrl.Height, cornerRadius, cornerRadius));
                }
            }
        }
    }
}
