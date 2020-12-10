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
    public partial class UCCourseGoalsEdit : UserControl
    {
        private string subId;
        private Panel pnl_container;
        private CCourseGoals cCourseGoals = new CCourseGoals();
        private string coursegoalId;
        private int count_hp;
        private int min_hp;
        private int max_hp;
        private int count_ctdt;
        private int min_ctdt;
        private int max_ctdt;
        private CourseGoal coursegoal;
        private List<string> CDRs = new List<string>();
        private List<string> CTDTs = new List<string>();
        public UCCourseGoalsEdit(string subId, string coursegoalId, Panel pnl_container)
        {
            InitializeComponent();
            count_hp = 0;
            count_ctdt = 0;
            this.subId = subId;
            this.pnl_container = pnl_container;
            coursegoal = cCourseGoals.findFromSubject(subId).Course_Goal.Where(c => c.ID_Goal == coursegoalId).SingleOrDefault();
            this.txt_GoalID.Text = coursegoal.ID_Goal;
            this.coursegoalId = coursegoalId;
            this.txt_Description.Text = coursegoal.Description_Goal;
            this.txt_CDRHP.Text = coursegoal.ID_CDR[0].ToString();
            this.txt_CDRCTDT.Text = coursegoal.ID_CTDT[0].ToString();

            CDRs = coursegoal.ID_CDR;
            CTDTs = coursegoal.ID_CTDT;
            max_hp = coursegoal.ID_CDR.Count();
            if (max_hp != 0)
                min_hp = 1;
            else
                min_hp = 0;

            max_ctdt = coursegoal.ID_CTDT.Count();
            if (max_ctdt != 0)
                min_ctdt = 1;
            else
                min_ctdt = 0;
        }

        private void btn_hpprevious_Click(object sender, EventArgs e)
        {
            if (count_hp > min_hp - 1)
            {
                this.txt_CDRHP.Text = coursegoal.ID_CDR[count_hp - 1];
                count_hp--;
                lbl_countHP.Text = (count_hp + 1).ToString();
            }
            else
                this.txt_CDRHP.Text = coursegoal.ID_CDR[0];
        }

        private void btn_hpnext_Click(object sender, EventArgs e)
        {
            if (count_hp < max_hp - 1)
            {
                this.txt_CDRHP.Text = coursegoal.ID_CDR[count_hp + 1];
                count_hp++;
                lbl_countHP.Text = (count_hp + 1).ToString();
            }
            else
                this.txt_CDRHP.Text = coursegoal.ID_CDR[max_hp - 1];
        }

        private void btn_ctdtprevious_Click(object sender, EventArgs e)
        {
            if (count_ctdt > min_ctdt - 1)
            {
                this.txt_CDRCTDT.Text = coursegoal.ID_CTDT[count_ctdt - 1];
                count_hp--;
                lbl_countCTDT.Text = (count_ctdt + 1).ToString();
            }
            else
                this.txt_CDRCTDT.Text = coursegoal.ID_CTDT[0];
        }

        private void btn_ctdtnext_Click(object sender, EventArgs e)
        {
            if (count_ctdt < max_ctdt - 1)
            {
                this.txt_CDRCTDT.Text = coursegoal.ID_CTDT[count_ctdt + 1];
                count_hp++;
                lbl_countCTDT.Text = (count_ctdt + 1).ToString();

            }
            else
                this.txt_CDRCTDT.Text = coursegoal.ID_CTDT[max_ctdt - 1];
        }

        private void btn_edithp_Click(object sender, EventArgs e)
        {
            if (txt_CDRHP.Text != "")
            {
                CDRs[count_hp] = this.txt_CDRHP.Text;
                MessageBox.Show("Sửa chi tiết CDR học phần thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
                this.txt_CDRHP.Text = CDRs[count_hp];
            }
        }

        private void btn_editctdt_Click(object sender, EventArgs e)
        {
            if (txt_CDRCTDT.Text != "")
            {
                CTDTs[count_ctdt] = this.txt_CDRCTDT.Text;
                MessageBox.Show("Sửa chi tiết CĐR CTĐT thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
                this.txt_CDRCTDT.Text = CTDTs[count_ctdt];

            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, subId);
            this.Dispose();
            cMain.loadUC(pnl_container, uCCourseGoals);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_GoalID.Text != "" && txt_Description.Text != "")
            {
                coursegoal.ID_Goal = this.txt_GoalID.Text;
                coursegoal.Description_Goal = this.txt_Description.Text;
                coursegoal.ID_CDR = CDRs;
                coursegoal.ID_CTDT = CTDTs;
                cCourseGoals.Update(subId, coursegoalId, coursegoal);
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

        private void UCCourseGoalsEdit_Load(object sender, EventArgs e)
        {

        }
    }
}
