using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_CNTT.Class;

namespace DA_CNTT
{
    public partial class UCPPGDAdd : UserControl
    {
        private CPPGD cPPGD = new CPPGD();
        private List<string> details = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        public UCPPGDAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddDetail_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
    }
}
