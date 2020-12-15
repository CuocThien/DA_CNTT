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
    
    public partial class UCSubjectsAdd : UserControl
    {
        private CSubject cSubject = new CSubject();
        private List<string> Prerequisite = new List<string>();
        private Panel pnl_container;
        private Subjects subs = new Subjects();
        private int count;
        public UCSubjectsAdd(Panel pnl_container)
        {
            InitializeComponent();
            this.pnl_container = pnl_container;
            count = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18();
            this.Dispose();
            cMain.loadUC(pnl_container, uCCnttBefore18);
        }

        private void btn_AddPrerequisite_Click(object sender, EventArgs e)
        {
            if (this.txt_Prerequisite.Text != "")
            {
                var prerequisite = this.txt_Prerequisite.Text;
                Prerequisite.Add(prerequisite);
                count++;
                lbl_count.Text = count.ToString();
                MessageBox.Show("Thêm chi tiết thành công");
                this.txt_Prerequisite.Text = "";
            }
            else
                MessageBox.Show("Vui lòng điền chi tiết vào");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_SubjectID.Text != "" && txt_SubjectName.Text != "" && txt_Credits.Text!="")
            {
                subs.Course_Code = txt_SubjectID.Text;
                subs.Course_Name = txt_SubjectName.Text;
                subs.Credits = txt_Credits.Text;
                subs.Prerequisite = Prerequisite;
                subs.Chapter_ID = "";
                subs.DetailOutline_ID = "";
                subs.Exam_ID = "";
                subs.Goal_ID = "";
                subs.PPGD_ID = "";
                subs.ProgramOutStandar_ID = "";
                subs.SelfStudy_ID = "";
                cSubject.addSubject(subs);
                this.txt_SubjectID.Text = "";
                this.txt_SubjectName.Text = "";
                this.txt_Credits.Text = "";
                MessageBox.Show("Thành Công");


                this.Dispose();
                UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18();
                cMain.loadUC(pnl_container, uCCnttBefore18);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
