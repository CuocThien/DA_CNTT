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
    public partial class UCDetailedOutline : UserControl
    {
        private string isAdmin;
        private Panel pnl_contain;
        private string sub_id;
        public UCDetailedOutline(Panel pnl_contain,string sub_id,string isAdmin)
        {
            InitializeComponent();
            this.pnl_contain = pnl_contain;
            this.sub_id = sub_id;
            this.isAdmin = isAdmin;
            this.dgv_DetailedOutline.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_DetailedOutline.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_DetailedOutline.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_DetailedOutline.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadDO(sub_id);
            if (!(load is null))
            {
                var descriptions = load.Description;
                string description = "";
                foreach (var d in descriptions)
                {
                    description += d;
                    description += "\n";
                }
                var student_duties = load.Student_Duties;
                string sd = "";
                foreach (var s in student_duties)
                {
                    sd += s + "\n";
                }
                var learning_materials = load.Learning_Materials;
                string lm = "";
                foreach(var l in learning_materials)
                {
                    lm += l + "\n";
                }
                var scientific_Ethics = load.Scientific_Ethics;
                string se = "";
                foreach(var SE in scientific_Ethics)
                {
                    se += SE + "\n";
                }    
                this.dgv_DetailedOutline.Rows.Add(description,  sd, lm, se);
            }
            
            if (isAdmin == "True")
            {
                btn_Add.Visible = true;
                btn_delete.Visible = true;
                btn_edit.Visible = true;
                if (dgv_DetailedOutline.Rows.Count >= 2)
                {
                    btn_Add.Visible = false;
                    if (dgv_DetailedOutline.Rows[0].Cells[0].Value.ToString() == "")
                        btn_Add.Visible = true;
                }
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
            UCDetailedOutlineAdd uCDetailedOutlineAdd = new UCDetailedOutlineAdd(sub_id, pnl_contain, isAdmin);
            cMain.loadUC(pnl_contain, uCDetailedOutlineAdd);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCDetailedOutlineEdit uCDetailedOutlineEdit = new UCDetailedOutlineEdit(pnl_contain, sub_id, isAdmin);
            cMain.loadUC(pnl_contain, uCDetailedOutlineEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CDetailedOutline cDetailedOutline = new CDetailedOutline();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cDetailedOutline.Delete(sub_id);
            this.Dispose();
            UCDetailedOutline uCDetailedOutline = new UCDetailedOutline(pnl_contain, sub_id, isAdmin);
            cMain.loadUC(pnl_contain, uCDetailedOutline);
        }

        private void dgv_DetailedOutline_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
        }
    }
}
