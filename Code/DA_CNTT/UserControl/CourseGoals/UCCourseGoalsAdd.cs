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
        private int count_hp;
        private int count_ctdt;

        public UCCousrseGoalAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            count_hp = 0;
            count_ctdt = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, sub_id);
            this.Dispose();
            cMain.loadUC(pnl_container, uCCourseGoals);
        }

        private void btn_CDRHP_Click(object sender, EventArgs e)
        {
            if (this.txt_CDRHP.Text != "")
            {
                var CDR = this.txt_CDRHP.Text;
                CDRs.Add(CDR);
                count_hp++;
                lbl_CDRHP.Text = count_hp.ToString();
                MessageBox.Show("Thêm CĐR học phần thành công");
                this.txt_CDRHP.Text = "";
            }
            else
                MessageBox.Show("Không để trống!!!");
        }

        private void btn_AddCDRCTDT_Click(object sender, EventArgs e)
        {
            if (this.txt_CDRCTDT.Text != "")
            {
                var CTDT = this.txt_CDRCTDT.Text;
                CTDTs.Add(CTDT);
                count_ctdt++;
                lbl_CDRCTDT.Text = count_ctdt.ToString();
                MessageBox.Show("Thêm CĐR CTĐT thành công");
                this.txt_CDRCTDT.Text = "";
            }
            else
                MessageBox.Show("Không để trống!!!");

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_GoalID.Text != "" && txt_Description.Text != "" && count_hp != 0 && count_ctdt != 0)
            {
                courseGoal.ID_Goal = this.txt_GoalID.Text;
                courseGoal.Description_Goal = this.txt_Description.Text;
                courseGoal.ID_CDR = CDRs;
                courseGoal.ID_CTDT = CTDTs;
                cCourseGoals.addCourseGoal(sub_id, courseGoal);
                this.txt_GoalID.Text = "";
                this.txt_Description.Text = "";
                MessageBox.Show("Thêm thông tin thành công");

                this.Dispose();
                UCCousrseGoalAdd uCCousrseGoalAdd = new UCCousrseGoalAdd(sub_id, pnl_container);
                cMain.loadUC(pnl_container, uCCousrseGoalAdd);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }
    }
}
