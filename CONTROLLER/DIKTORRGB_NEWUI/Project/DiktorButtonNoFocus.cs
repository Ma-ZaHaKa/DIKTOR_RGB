using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomButton
{
    class DiktorButtonNoFocus : Button // из управления close minimize 
    {
        public DiktorButtonNoFocus()
            : base()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }
    /*class NoFocusButton : Button // for copy
    {
        public NoFocusButton()
            : base()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }
    }*/
}
