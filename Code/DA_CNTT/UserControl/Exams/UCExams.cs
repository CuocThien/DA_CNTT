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
    public partial class UCExams : UserControl
    {
        private string subId;
        private string examId;
        private Panel pnl_contain;
        private string isAdmin;
        public UCExams(Panel pnl_container, string sub_id,string isAdmin)
        {
            InitializeComponent();
            subId = sub_id;
            this.isAdmin = isAdmin;
            this.dgv_Exams.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon;
            this.dgv_Exams.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            this.dgv_Exams.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Khaki;
            this.dgv_Exams.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Red;
            var controller = new MainController();
            var load = controller.loadExams(sub_id);
            this.pnl_contain = pnl_container;
            if (!(load is null))
            {
                var exams = controller.loadExams(sub_id).Exam;
                foreach (var e in exams)
                {
                    var CDRs = e.ID_CDR.ToList();
                    string CDR = "";
                    foreach (var cdr in CDRs)
                    {
                        CDR += cdr.ToString() + " \n";
                    }
                    this.dgv_Exams.Rows.Add(e.ID_Test,e.Exercise,e.Date,e.Tool,CDR,e.Percentage);
                }
            }
            if (isAdmin == "True")
            {
                btn_Add.Visible = true;
                btn_delete.Visible = true;
                btn_edit.Visible = true;
            }
            else
            {
                btn_edit.Visible = false;
                btn_delete.Visible = false;
                btn_Add.Visible = false;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UCExamsAdd uCExamsAdd = new UCExamsAdd(subId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCExamsAdd);
        }

        private void dgv_Exams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgv_Exams.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.btn_edit.Enabled = true;
            this.btn_delete.Enabled = true;
            this.examId = row;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            UCExamsEdit uCExamsEdit = new UCExamsEdit(subId, examId, pnl_contain,isAdmin);
            cMain.loadUC(pnl_contain, uCExamsEdit);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            CExam cExam = new CExam();
            var result = MessageBox.Show("Chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                cExam.Delete(subId, examId);
            this.Dispose();
            UCExams uCExams = new UCExams(pnl_contain, subId,isAdmin);
            cMain.loadUC(pnl_contain, uCExams);
        }
    }
}
