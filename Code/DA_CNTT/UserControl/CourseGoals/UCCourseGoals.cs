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
    public partial class UCCourseGoals : UserControl
    {
        private string subId;
        private string courseGoalId;
        private Panel pnl_contain;
        public UCCourseGoals(Panel pnl_container, string sub_id)
        {
            InitializeComponent();
            subId = sub_id;
            this.dgv_CourseGoals.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_CourseGoals.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_CourseGoals.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_CourseGoals.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadCourseGoals(sub_id);
            this.pnl_contain = pnl_container;
            if (!(load is null))
            {
                var coursegoals = controller.loadCourseGoals(sub_id).Course_Goal;
                foreach (var c in coursegoals)
                {
                    var CDRs = c.ID_CDR.ToList();
                    var CTDTs = c.ID_CTDT.ToList();
                    string CDR = "";
                    string CTDT = "";
                    foreach (var cdr in CDRs)
                    {
                        CDR += cdr.ToString() + " \n";
                    }
                    foreach (var ctdt in CTDTs)
                    {
                        CTDT += ctdt.ToString() + " \n";
                    }
                    this.dgv_CourseGoals.Rows.Add(c.ID_Goal, c.Description_Goal, CDR,CTDT);
                }
            }
        }

        private void UCCourseGoals_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CourseGoals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_CourseGoals.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.courseGoalId = row;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UCCousrseGoalAdd uCCousrseGoalAdd = new UCCousrseGoalAdd(subId, pnl_contain);
            cMain.loadUC(pnl_container, uCCousrseGoalAdd);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CCourseGoals cCourseGoals = new CCourseGoals();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cCourseGoals.Delete(subId, courseGoalId);
            this.Dispose();
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_contain, subId);
            cMain.loadUC(pnl_contain, uCCourseGoals);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCCourseGoalsEdit uCCourseGoalsEdit = new UCCourseGoalsEdit(subId, courseGoalId, pnl_contain);
            cMain.loadUC(pnl_contain, uCCourseGoalsEdit);
        }
    }
}
