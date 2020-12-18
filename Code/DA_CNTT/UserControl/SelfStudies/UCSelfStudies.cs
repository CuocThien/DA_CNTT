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
using DA_CNTT.Models;
using DA_CNTT.Class;

namespace DA_CNTT
{
    public partial class UCSelfStudies : UserControl
    {
        private string subId;
        private string selfstudyId;
        private Panel pnl_contain;
        private string isAdmin;
        public UCSelfStudies(Panel pnl_container, string sub_id, string isAdmin)
        {
            InitializeComponent();
            subId = sub_id;
            this.isAdmin = isAdmin;
            this.dgv_SelfStudies.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_SelfStudies.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_SelfStudies.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_SelfStudies.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadSS(sub_id);
            this.pnl_contain = pnl_container;
            if (!(load is null))
            {
                var selfstudies = controller.loadSS(sub_id).SelfStudy;
                foreach (var s in selfstudies)
                {
                    var details = s.Details.ToList();
                    string detail = "";
                    foreach (var d in details)
                    {
                        detail += "Đọc thêm: \n";
                        detail += d.Read + " \n\n";
                        detail += "Chương: \n";
                        foreach(var c in d.Chapter)
                        {
                            detail += c + " \n";
                        }
                        detail += "\n";
                    }
                    var request = s.Request.ToList();
                    string req = "";
                    foreach(var r in request)
                    {
                        req += r + " \n";
                    }    
                    this.dgv_SelfStudies.Rows.Add(s.ID, detail, req);
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
            UCSelfStudiesAdd uCSelfStudiesAdd = new UCSelfStudiesAdd(subId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCSelfStudiesAdd);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCSelfStudiesEdit uCSelfStudiesEdit = new UCSelfStudiesEdit(subId, selfstudyId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCSelfStudiesEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CSelfStudy cSelfStudy = new CSelfStudy();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cSelfStudy.Delete(subId, selfstudyId);
            this.Dispose();
            UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_contain, subId,isAdmin);
            cMain.loadUC(pnl_contain, uCSelfStudies);
        }

        private void dgv_SelfStudies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_SelfStudies.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.selfstudyId = row;
        }
    }
}
