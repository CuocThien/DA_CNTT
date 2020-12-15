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
    public partial class UCSelfStudiesAdd : UserControl
    {
        private CSelfStudy cSelfStudy = new CSelfStudy();
        private List<string> chapters = new List<string>();
        private List<string> requests = new List<string>();
        SelfStudy selfStudy = new SelfStudy();
        private string sub_id;
        private Panel pnl_container;
        private int countChapters;
        private int countRequests;
        List<Details> details = new List<Details>();
        private Details detail = new Details();
        public UCSelfStudiesAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            countChapters = 0;
            countRequests = 0;
        }

        private void btn_showDetail_Click(object sender, EventArgs e)
        {
            
            #region control buttons
            lbl_chapter.Visible = true;
            lbl_countChapter.Visible = true;
            lbl_read.Visible = true;

            btn_AddChapter.Visible = true;
            btn_addDetail.Visible = true;
            btn_showDetail.Visible = false;
            btn_Add.Visible = false;

            txt_chapter.Visible = true;
            txt_read.Visible = true;
            #endregion
        }

        private void btn_addDetail_Click(object sender, EventArgs e)
        {
            detail.Chapter = chapters;
            detail.Read = txt_read.Text;
            details.Add(detail);
            countChapters = 0;
            lbl_countChapter.Text = countChapters.ToString();
            detail = new Details();
            chapters = new List<string>();
            txt_read.Text = "";
            MessageBox.Show("Thêm chi tiết thành công");
            #region control buttons
            lbl_chapter.Visible = false;
            lbl_countChapter.Visible = false;
            lbl_read.Visible = false;

            btn_AddChapter.Visible = false;
            btn_Add.Visible = true;
            btn_showDetail.Visible = true;
            btn_addDetail.Visible = false;

            txt_chapter.Visible = false;
            txt_read.Visible = false;
            #endregion
        }

        private void btn_AddChapter_Click(object sender, EventArgs e)
        {
            if (txt_chapter.Text != "")
            {
                var Chapter = this.txt_chapter.Text;
                chapters.Add(Chapter);
                MessageBox.Show("Thêm chương tự học thành công");
                this.txt_chapter.Text = "";
                countChapters++;
                lbl_countChapter.Text = countChapters.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        
        }

        private void btn_addRequest_Click(object sender, EventArgs e)
        {
            if (txt_request.Text != "")
            {
                var Request = this.txt_request.Text;
                requests.Add(Request);
                MessageBox.Show("Thêm yêu cầu tự học thành công");
                this.txt_request.Text = "";
                countRequests++;
                lbl_countRequest.Text = countRequests.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_SelfStudyID.Text != "" && countRequests != 0)
            {
                selfStudy.ID = this.txt_SelfStudyID.Text;
                selfStudy.Details = details;
                selfStudy.Request = requests;
                cSelfStudy.addSelfStudy(sub_id, selfStudy);
                this.txt_SelfStudyID.Text = "";
                MessageBox.Show("Thành Công");

                this.Dispose();
                UCSelfStudiesAdd uCSelfStudiesAdd = new UCSelfStudiesAdd(sub_id, pnl_container);
                cMain.loadUC(pnl_container, uCSelfStudiesAdd);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_container,sub_id);
            cMain.loadUC(pnl_container, uCSelfStudies);
        }
    }
}
