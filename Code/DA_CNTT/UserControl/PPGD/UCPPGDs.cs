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
using DA_CNTT.Class;

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
            UCPPGDsAdd uCPPGDAdd = new UCPPGDsAdd(subId,pnl_contain);
            cMain.loadUC(pnl_contain, uCPPGDAdd);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCPPGDsEdit uCPPGDsEdit = new UCPPGDsEdit(subId, ppgdId, pnl_contain);
            cMain.loadUC(pnl_contain, uCPPGDsEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CPPGD cPPGD = new CPPGD();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cPPGD.delete(subId, ppgdId);
            this.Dispose();
            UCPPGDs uCPPGDs = new UCPPGDs(pnl_contain, subId);
            cMain.loadUC(pnl_contain, uCPPGDs);
        }

        private void dgv_PPGDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_PPGDs.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.ppgdId = row;
        }
    }
}
