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
        private string isAdmin;
        private Label lbl_subname;
        public UCCnttBefore18(string isAdmin, Label lbl_subname)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.lbl_subname = lbl_subname;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Content.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var sub = controller.loadsubjects();
            foreach (var item in sub)
            {
                this.dgv_Content.Rows.Add(item.Course_Code, item.Course_Name,item.Credits,item.Semester);
            }
            this.dgv_Content.Sort(dgv_Content.Columns[3], System.ComponentModel.ListSortDirection.Ascending);
            if (isAdmin == "True")
                btn_Add.Visible = true;
            else
                btn_Add.Visible = false;
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
            UCManageSubjects uCManageSubjects = new UCManageSubjects(pnl_container,row,isAdmin,lbl_subname);
            cMain.loadUC(pnl_container, uCManageSubjects);
            //MessageBox.Show(row);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UCSubjectsAdd uCSubjectsAdd = new UCSubjectsAdd(pnl_container,isAdmin,lbl_subname);
            cMain.loadUC(pnl_container, uCSubjectsAdd);
        }

    }
}
