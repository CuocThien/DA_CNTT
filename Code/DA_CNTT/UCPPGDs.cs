using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_CNTT.Controllers;

namespace DA_CNTT
{
    public partial class UCPPGDs : UserControl
    {
        private string subId;
        private string ppgdId;
        private Panel pnl_contain;
        public UCPPGDs(Panel pnl_container, string sub_id)
        {
            InitializeComponent();
            subId = sub_id;
            this.dgv_PPGDs.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_PPGDs.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_PPGDs.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_PPGDs.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadPPGDs(sub_id);
            this.pnl_contain = pnl_container;
            if (!(load is null))
            {
                var ppgds = controller.loadPPGDs(sub_id).PPGD;
                foreach (var c in ppgds)
                {
                    var detail = c.Detail.ToList();
                    string details = "";
                    foreach (var d in detail)
                    {
                        details += d.ToString() + " \n ";
                    }
                    this.dgv_PPGDs.Rows.Add(c.ID, details);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Chapters_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
