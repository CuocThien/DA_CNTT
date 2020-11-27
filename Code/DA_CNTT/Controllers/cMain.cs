using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DA_CNTT
{
    public class cMain
    {
        public static void loadUC(Panel pnl_container, UserControl uc)
        {
            pnl_container.Controls.Clear();
            pnl_container.Controls.Add(uc);
        }
    }
}
