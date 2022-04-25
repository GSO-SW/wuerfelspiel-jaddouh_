using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Wuerfelspiel
{
    public partial class UcWuerfel
    {
        private int wert;
        Wuerfel wuerfel = new Wuerfel();

        public UcWuerfel()
        {
        }
        public UcWuerfel(Wuerfel wuerfel):this()
        {
            this.wuerfel = wuerfel;
        }
        
        private void btn_Click(object sender, EventArgs e)
        {

        }
        private void btn_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
