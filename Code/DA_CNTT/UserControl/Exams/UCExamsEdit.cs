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
    public partial class UCExamsEdit : UserControl
    {
        private string subId;
        private string isAdmin;
        private Panel pnl_container;
        private CExam cExam = new CExam();
        private string examId;
        private int count;
        private int min;
        private int max;
        private Exam exam;
        private List<string> CDRs = new List<string>();
        public UCExamsEdit(string subId, string examId, Panel pnl_container,string isAdmin)
        {
            InitializeComponent();
            count = 0;
            this.isAdmin = isAdmin;
            this.subId = subId;
            this.examId = examId;
            this.pnl_container = pnl_container;
            exam = cExam.findfromsubject(subId).Exam.Where(c => c.ID_Test == examId).SingleOrDefault();
            this.txt_ExamID.Text = exam.ID_Test;
            this.txt_Description.Text = exam.Exercise;
            this.txt_date.Text = exam.Date;
            this.txt_tool.Text = exam.Tool;
            this.txt_percentage.Text = exam.Percentage;
            this.txt_CDR.Text = exam.ID_CDR[0].ToString();

            CDRs = exam.ID_CDR;
            max = exam.ID_CDR.Count();
            if (max != 0)
                min = 1;
            else
                min = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCExams uCExams = new UCExams(pnl_container, subId,isAdmin);
            this.Dispose();
            cMain.loadUC(pnl_container, uCExams);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (count > min - 1)
            {
                this.txt_CDR.Text = exam.ID_CDR[count - 1];
                count--;
                lbl_countHP.Text = (count + 1).ToString();
            }
            else
                this.txt_CDR.Text = exam.ID_CDR[0];
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (count < max - 1)
            {
                this.txt_CDR.Text = exam.ID_CDR[count + 1];
                count++;
                lbl_countHP.Text = (count + 1).ToString();

            }
            else
                this.txt_CDR.Text = exam.ID_CDR[max - 1];
        }

        private void btn_editcdr_Click(object sender, EventArgs e)
        {
            if (txt_CDR.Text != "")
            {
                CDRs[count] = this.txt_CDR.Text;
                MessageBox.Show("Sửa CĐR học phần thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }    
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_date.Text != "" && txt_Description.Text != "" && txt_ExamID.Text != "" && txt_percentage.Text != "" && txt_tool.Text != "")
            {
                exam.ID_Test = this.txt_ExamID.Text;
                exam.Exercise = this.txt_Description.Text;
                exam.ID_CDR = CDRs;
                exam.Date = this.txt_date.Text;
                exam.Tool = this.txt_tool.Text;
                exam.Percentage = this.txt_percentage.Text;
                cExam.Update(subId, examId, exam);
                MessageBox.Show("Sửa thông tin thành công");
                UCExams uCExams = new UCExams(pnl_container,subId,isAdmin);
                cMain.loadUC(pnl_container, uCExams);
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
    }
}
