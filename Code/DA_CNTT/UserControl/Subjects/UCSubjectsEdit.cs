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
    public partial class UCSubjectsEdit : UserControl
    {
        private string isAdmin;
        private CSubject cSubject = new CSubject();
        private List<string> Prerequisite = new List<string>();
        private Panel pnl_container;
        private string sub_id;
        private Subjects subs = new Subjects();
        private int count;
        private int min;
        private int max;
        private Label lbl_subname;
        public UCSubjectsEdit(Panel pnl_container,string subid,string isAdmin,Label lbl_subname)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.sub_id = subid;
            this.lbl_subname = lbl_subname;
            this.pnl_container = pnl_container;
            count = 0;
            subs = cSubject.findAll().Where(i => i.Course_Code == sub_id).SingleOrDefault();

            Prerequisite = subs.Prerequisite;
            this.txt_SubjectID.Text = subs.Course_Code;
            this.txt_SubjectName.Text = subs.Course_Name;
            this.txt_Credits.Text = subs.Credits;
            if (Prerequisite.Count > 0)
                this.txt_Prerequisite.Text = Prerequisite[0];
            else
            {
                this.txt_Prerequisite.Text = "";
                this.txt_Prerequisite.Enabled = false;
                this.btn_EditPrerequisite.Enabled = false;
                this.btn_nextPrerequisite.Enabled = false;
                this.btn_PreviousPrerequisite.Enabled = false;
            }
            this.txt_Semester.Text = subs.Semester;
            max = subs.Prerequisite.Count();
            if (max != 0)
                min = 1;
            else
                min = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UCManageSubjects uC = new UCManageSubjects(pnl_container, sub_id,isAdmin,lbl_subname);
            cMain.loadUC(pnl_container, uC);
        }

        private void btn_PreviousPrerequisite_Click(object sender, EventArgs e)
        {
            if (count > min - 1)
            {
                this.txt_Prerequisite.Text = Prerequisite[count - 1];
                count--;
                lbl_count.Text = (count + 1).ToString();
            }
            else
                this.txt_Prerequisite.Text = Prerequisite[0];
        }

        private void btn_EditPrerequisite_Click(object sender, EventArgs e)
        {
            if (txt_Prerequisite.Text != "")
            {
                Prerequisite[count] = this.txt_Prerequisite.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_nextPrerequisite_Click(object sender, EventArgs e)
        {
            if (count < max - 1)
            {
                this.txt_Prerequisite.Text = Prerequisite[count + 1];
                count++;
                lbl_count.Text = (count + 1).ToString();

            }
            else
                this.txt_Prerequisite.Text = Prerequisite[max - 1];
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_SubjectID.Text != "" && txt_SubjectName.Text !="" && txt_Credits.Text != "" && txt_Semester.Text!="")
            {
                subs.Course_Code = this.txt_SubjectID.Text;
                subs.Course_Name = this.txt_SubjectName.Text;
                subs.Credits = this.txt_Credits.Text;
                subs.Prerequisite = Prerequisite;
                subs.Semester = txt_Semester.Text;
                cSubject.Update(sub_id, subs);
                MessageBox.Show("Sửa thông tin thành công");
                this.Dispose();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
    }
}
