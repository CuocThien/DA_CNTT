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
    public partial class UCProgramOutStandards : UserControl
    {
        private string subId;
        private string CDRId;
        private string isAdmin;
        private Panel pnl_contain;
        public UCProgramOutStandards(Panel pnl_container, string sub_id, string isAdmin)
        {
            InitializeComponent();
            subId = sub_id;
            this.isAdmin = isAdmin;
            this.dgv_ProgramOutStandards.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_ProgramOutStandards.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_ProgramOutStandards.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_ProgramOutStandards.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadPOS(sub_id);
            this.pnl_contain = pnl_container;
            if (!(load is null))
            {
                var POSs = controller.loadPOS(sub_id).OutComes;
                foreach (var e in POSs)
                {
                    var CDIOs = e.ID_CDIO.ToList();
                    string CDIO = "";
                    foreach (var cdio in CDIOs)
                    {
                        CDIO += cdio.ToString() + " \n";
                    }
                    this.dgv_ProgramOutStandards.Rows.Add(e.ID_CDR, e.Description_CDR, CDIO);
                }
            }
            if(isAdmin=="True")
            {
                btn_Add.Visible = true;
                btn_delete.Visible = true;
                btn_edit.Visible = true;
            }
            else
            {
                btn_edit.Visible = false;
                btn_delete.Visible = false;
                btn_Add.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UCProgramOutStandardsAdd uCProgramOutStandardsAdd = new UCProgramOutStandardsAdd(subId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCProgramOutStandardsAdd);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCProgramOutStandardsEdit uCProgramOutStandardsEdit = new UCProgramOutStandardsEdit(subId, CDRId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCProgramOutStandardsEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CProgramOutStandards cPOS = new CProgramOutStandards();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cPOS.Delete(subId, CDRId);
            this.Dispose();
            UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_contain, subId,isAdmin);
            cMain.loadUC(pnl_contain, uCProgramOutStandards);
        }

        private void dgv_ProgramOutStandards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_ProgramOutStandards.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.CDRId = row;
        }
    }
}
