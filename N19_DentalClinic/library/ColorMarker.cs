using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_DentalClinic.library
{
    public class ColorMarker
    {
        public static void ButtonColor(Button button, string hexColorButton, string hexColorText)
        {
            button.BackColor = ColorTranslator.FromHtml("#" + hexColorButton);
            button.ForeColor = ColorTranslator.FromHtml("#" + hexColorText);
        }
    }
}
