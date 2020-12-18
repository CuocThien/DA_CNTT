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
    public partial class UCChapters : UserControl
    {
        private string subId;
        private string chapterId;
        private Panel pnl_contain;
        private string isAdmin;
        public UCChapters(Panel pnl_container, string sub_id,string isAdmin)
        {
            InitializeComponent();
            subId = sub_id;
            this.isAdmin = isAdmin;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadchapters(sub_id);
            this.pnl_contain = pnl_container;
            if(!(load is null))
            {     
                var chapters = controller.loadchapters(sub_id).Chapter;
                foreach (var c in chapters)
                {
                    var detail = c.Detail.ToList();
                    string details = "";
                    foreach (var d in detail)
                    {
                        details += d.ToString() + " \n ";
                    }
                    this.dgv_Chapters.Rows.Add(c.ID, c.Name, details);
                }
            }
            if (isAdmin == "True")
            {
                this.btn_Add.Visible = true;
                this.btn_delete.Visible = true;
                this.btn_edit.Visible = true;
            }
            else
            {
                this.btn_edit.Visible = false;
                this.btn_delete.Visible = false;
                this.btn_Add.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UCChaptersAdd uCChaptersAdd = new UCChaptersAdd(subId,pnl_container,isAdmin);
            cMain.loadUC(pnl_container, uCChaptersAdd);
        }

        private void dgv_Chapters_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            var row = dgv_Chapters.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.chapterId = row;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCChaptersEdit uCChaptersEdit = new UCChaptersEdit(subId, chapterId, pnl_container,isAdmin);
            cMain.loadUC(pnl_container, uCChaptersEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CChapters cChapters = new CChapters();
            var result = MessageBox.Show( "Chắc chắn xóa?","Thông báo",MessageBoxButtons.OKCancel);
            if(result==DialogResult.OK)
                cChapters.Delete(subId, chapterId);
            this.Dispose();
            UCChapters uCChapters = new UCChapters(pnl_contain, subId,isAdmin);
            cMain.loadUC(pnl_contain, uCChapters);
        }
    }
}
