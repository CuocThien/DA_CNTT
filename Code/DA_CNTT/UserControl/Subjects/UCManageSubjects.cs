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
        public UCManageSubjects(Panel pnl_contain, string Subject_ID)

        {
            InitializeComponent();
            Sub_id = Subject_ID;
            this.pnl_contain = pnl_contain;
        }

        private void btn_Chapter_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCChapters);
        }

        private void btn_CourseGoals_Click(object sender, EventArgs e)
        {
            UCCourseGoals uCCourseGoals = new UCCourseGoals(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCCourseGoals);
        }

        private void btn_exams_Click(object sender, EventArgs e)
        {
            UCExams uCExams = new UCExams(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCExams);
        }

        private void btn_ppgd_Click(object sender, EventArgs e)
        {
            UCPPGDs uCPPGDs = new UCPPGDs(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCPPGDs);
        }

        private void btn_CDR_Click(object sender, EventArgs e)
        {
            UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCProgramOutStandards);
        }

        private void btn_SelfStudies_Click(object sender, EventArgs e)
        {
            UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_container, Sub_id);
            cMain.loadUC(pnl_container, uCSelfStudies);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCSubjectsEdit uCSubjectsEdit = new UCSubjectsEdit(pnl_contain, Sub_id);
            cMain.loadUC(pnl_container, uCSubjectsEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CSubject cSubject = new CSubject();
            cSubject.delete(Sub_id);
            MessageBox.Show("Xóa môn học thành công");
            this.Dispose();
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18();
            cMain.loadUC(pnl_contain, uCCnttBefore18);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18();
            cMain.loadUC(pnl_contain, uCCnttBefore18);
        }
    }
}
