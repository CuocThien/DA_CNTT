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
    public partial class UCExamsAdd : UserControl
    {
        private CExam cExam = new CExam();
        private List<string> CDRs = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        private Exam exam = new Exam();
        private int count;
        public UCExamsAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            count = 0;
        }

        private void btn_AddCDR_Click(object sender, EventArgs e)
        {
            if (txt_CDR.Text != "")
            {
                var CDR = this.txt_CDR.Text;
                CDRs.Add(CDR);
                MessageBox.Show("Thêm CĐR học phần thành công");
                this.txt_CDR.Text = "";
                count++;
                lbl_countHP.Text = count.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCExams uCExams = new UCExams(pnl_container, sub_id);
            this.Dispose();
            cMain.loadUC(pnl_container, uCExams);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_date.Text != "" && txt_Description.Text != "" && txt_ExamID.Text != "" && txt_percentage.Text != "" && txt_tool.Text != "")
            {
                exam.ID_Test = this.txt_ExamID.Text;
                exam.Exercise = this.txt_Description.Text;
                exam.Date = this.txt_date.Text;
                exam.Tool = this.txt_tool.Text;
                exam.ID_CDR = CDRs;
                exam.Percentage = this.txt_percentage.Text;
                cExam.addExam(sub_id, exam);
                this.txt_ExamID.Text = "";
                this.txt_Description.Text = "";
                this.txt_date.Text = "";
                this.txt_tool.Text = "";
                this.txt_percentage.Text = "";
                MessageBox.Show("Thành Công");

                this.Dispose();
                UCExamsAdd uCExamsAdd = new UCExamsAdd(sub_id, pnl_container);
                cMain.loadUC(pnl_container, uCExamsAdd);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }    
        }
    }
}
