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
    public partial class UCCnttBefore18 : UserControl
    {
        public UCCnttBefore18()
        {
            InitializeComponent();
            this.dgv_Content.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var sub = controller.loadsubjects();
            foreach (var item in sub)
            {
                this.dgv_Content.Rows.Add(item.Course_Code, item.Course_Name,item.Credits);
            }    
        }




        private void txt_Search_TextChanged_1(object sender, EventArgs e)
        {
            var controller = new MainController();
            var sub = controller.loadsubjects();
            var subs = sub.Where(item => item.Course_Code.ToLower().Contains(this.txt_Search.Text.ToLower())
              || item.Course_Name.ToLower().Contains(this.txt_Search.Text.ToLower())).ToList();
            this.dgv_Content.Rows.Clear();
            foreach (var s in subs)
            {
                this.dgv_Content.Rows.Add(s.Course_Code, s.Course_Name, s.Credits);
            }
        }

        private void dgv_Content_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_Content.Rows[e.RowIndex].Cells[0].Value.ToString();
            UCManageSubjects uCManageSubjects = new UCManageSubjects(row);
            cMain.loadUC(pnl_container, uCManageSubjects);
            //MessageBox.Show(row);
        }
    }
}
