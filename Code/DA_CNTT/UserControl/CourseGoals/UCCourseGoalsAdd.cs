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
using DA_CNTT.Models;

namespace DA_CNTT
{
    public partial class UCCousrseGoalAdd : UserControl
    {
        private CCourseGoals  cCourseGoals = new CCourseGoals();
        private CourseGoal courseGoal = new CourseGoal();
        private List<string> CDRs = new List<string>();
        private List<string> CTDTs = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        public UCCousrseGoalAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, sub_id);
            this.Dispose();
            cMain.loadUC(pnl_container, uCCourseGoals);
        }

        private void btn_CDRHP_Click(object sender, EventArgs e)
        {
            var CDR = this.txt_CDRHP.Text;
            CDRs.Add(CDR);
            MessageBox.Show("Thành Công");
            this.txt_CDRHP.Text = "";
        }

        private void btn_AddCDRCTDT_Click(object sender, EventArgs e)
        {
            var CTDT = this.txt_CDRCTDT.Text;
            CTDTs.Add(CTDT);
            MessageBox.Show("Thành Công");
            this.txt_CDRCTDT.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            courseGoal.ID_Goal = this.txt_GoalID.Text;
            courseGoal.Description_Goal = this.txt_Description.Text;
            courseGoal.ID_CDR = CDRs;
            courseGoal.ID_CTDT = CTDTs;
            cCourseGoals.addCourseGoal(sub_id, courseGoal);
            this.txt_GoalID.Text = "";
            this.txt_Description.Text = "";
            MessageBox.Show("Thành Công");
        }
    }
}
