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

namespace DA_CNTT
{
    public partial class UCManageSubjects : UserControl
    {
        private string Sub_id;
        private Panel pnl_contain;
        private string isAdmin;
        public UCManageSubjects(Panel pnl_contain, string Subject_ID,string isAdmin)

        {
            InitializeComponent();
            Sub_id = Subject_ID;
            this.pnl_contain = pnl_contain;
            this.isAdmin = isAdmin;
            if(isAdmin=="True")
            {
                btn_delete.Visible = true;
                btn_edit.Visible = true;
            }
            else
            {
                btn_edit.Visible = false;
                btn_delete.Visible = false;
            }
        }

        private void btn_Chapter_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCChapters);
        }

        private void btn_CourseGoals_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCCourseGoals);
        }

        private void btn_exams_Click(object sender, EventArgs e)
        {
            UCExams uCExams = new UCExams(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCExams);
        }

        private void btn_ppgd_Click(object sender, EventArgs e)
        {
            UCPPGDs uCPPGDs = new UCPPGDs(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCPPGDs);
        }

        private void btn_CDR_Click(object sender, EventArgs e)
        {
            UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCProgramOutStandards);
        }

        private void btn_SelfStudies_Click(object sender, EventArgs e)
        {
            UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_container, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCSelfStudies);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCSubjectsEdit uCSubjectsEdit = new UCSubjectsEdit(pnl_contain, Sub_id,isAdmin);
            cMain.loadUC(pnl_container, uCSubjectsEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CSubject cSubject = new CSubject();
            cSubject.delete(Sub_id);
            MessageBox.Show("Xóa môn học thành công");
            this.Dispose();
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18(isAdmin);
            cMain.loadUC(pnl_contain, uCCnttBefore18);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18(isAdmin);
            cMain.loadUC(pnl_contain, uCCnttBefore18);
        }
    }
}
