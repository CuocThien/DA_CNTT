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
    public partial class UCSelfStudiesEdit : UserControl
    {
        private CSelfStudy cSelfStudy = new CSelfStudy();
        private List<string> chapters = new List<string>();
        private List<string> requests = new List<string>();
        SelfStudy selfStudy = new SelfStudy();
        private string sub_id;
        private string selfstudyId;
        private Panel pnl_container;
        private int countChapters;
        private int countRequests;
        private int countDetail;
        private int min_request;
        private int max_request;
        private int min_chapter;
        private int max_chapter;
        private int min_detail;
        private int max_detail;
        List<Details> details = new List<Details>();
        private Details detail = new Details();
        public UCSelfStudiesEdit(string subId, string selfStudyId, Panel pnl_container)
        {
            InitializeComponent();
            countRequests = 0;
            countDetail = 0;
            countChapters = 0;
            this.sub_id = subId;
            this.selfstudyId = selfStudyId;
            this.pnl_container = pnl_container;
            selfStudy = cSelfStudy.findfromsubject(subId).SelfStudy.Where(s => s.ID == selfstudyId).SingleOrDefault();

            details = selfStudy.Details;
            this.txt_SelfStudyID.Text = selfStudy.ID;
            this.txt_request.Text = selfStudy.Request[0].ToString();
            this.txt_read.Text = details[countDetail].Read.ToString();
            this.txt_chapter.Text = details[countDetail].Chapter[0].ToString();

            requests = selfStudy.Request;
            max_request = selfStudy.Request.Count();
            if (max_request != 0)
                min_request = 1;
            else
                min_request = 0;
            max_detail = selfStudy.Details.Count();
            if (max_detail != 0)
                min_detail = 1;
            else
                min_detail = 0;
        }

        private void btn_nextRequest_Click(object sender, EventArgs e)
        {
            if (countRequests < max_request - 1)
            {
                this.txt_request.Text = requests[countRequests + 1];
                countRequests++;
                lbl_countRequest.Text = (countRequests + 1).ToString();

            }
            else
                this.txt_request.Text = requests[max_request - 1];
        }

        private void btn_previousRequest_Click(object sender, EventArgs e)
        {
            if (countRequests > min_request - 1)
            {
                this.txt_request.Text = requests[countRequests - 1];
                countRequests--;
                lbl_countRequest.Text = (countRequests + 1).ToString();
            }
            else
                this.txt_request.Text = requests[0];
        }

        private void btn_editRequest_Click(object sender, EventArgs e)
        {
            if (txt_request.Text != "")
            {
                requests[countRequests] = this.txt_request.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_previousChapter_Click(object sender, EventArgs e)
        {
            countChapters = int.Parse(lbl_countChapter.Text)-1;
            max_chapter = details[int.Parse(lbl_Detail.Text) - 1].Chapter.Count();
            if (max_chapter != 0)
                min_chapter = 1;
            else
                min_chapter = 0;
            if (countChapters > min_chapter - 1)
            {
                this.txt_chapter.Text = details[int.Parse(lbl_Detail.Text)-1].Chapter[countChapters-1];
                countChapters--;
                lbl_countChapter.Text = (countChapters+1).ToString();
            }
            else
                this.txt_chapter.Text = details[int.Parse(lbl_Detail.Text) - 1].Chapter[0];
        }

        private void btn_nextChapter_Click(object sender, EventArgs e)
        {
            countChapters = int.Parse(lbl_countChapter.Text)-1;
            max_chapter = details[int.Parse(lbl_Detail.Text) - 1].Chapter.Count();
            if (max_chapter != 0)
                min_chapter = 1;
            else
                min_chapter = 0;
            if (countChapters < max_chapter-1)
            {
                this.txt_chapter.Text = details[int.Parse(lbl_Detail.Text) - 1].Chapter[countChapters+1];
                countChapters++;
                lbl_countChapter.Text = (countChapters+1).ToString();
            }
            else
                this.txt_chapter.Text = details[int.Parse(lbl_Detail.Text) - 1].Chapter[max_chapter-1];

        }

        private void btn_editChapter_Click(object sender, EventArgs e)
        {
            if (txt_chapter.Text != "")
            {
                details[int.Parse(lbl_Detail.Text)-1].Chapter[int.Parse(lbl_countChapter.Text)-1] = this.txt_chapter.Text;
                MessageBox.Show("Sửa chương thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_previousDetail_Click(object sender, EventArgs e)
        {
            if (countDetail > min_detail-1)
            {
                countDetail--;
                lbl_Detail.Text = (countDetail + 1).ToString();
                this.txt_read.Text = details[countDetail].Read.ToString();
                this.txt_chapter.Text = details[countDetail].Chapter[0].ToString();
                lbl_Detail.Text = (countDetail+1).ToString();

                lbl_countChapter.Text = "1";
            }
        }

        private void btn_nextDetail_Click(object sender, EventArgs e)
        {
            if (countDetail < max_detail - 1)
            {
                countDetail++;
                lbl_Detail.Text = (countDetail + 1).ToString();
                this.txt_read.Text = details[countDetail].Read.ToString();
                this.txt_chapter.Text = details[countDetail].Chapter[0].ToString();
                lbl_Detail.Text = (countDetail+1).ToString();

                lbl_countChapter.Text = "1";
            }
        }

        private void btn_editDetail_Click(object sender, EventArgs e)
        {
            selfStudy.Details= details;
            MessageBox.Show("Sửa chi tiết thành công");

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (txt_SelfStudyID.Text != "")
            {
                selfStudy.ID = this.txt_SelfStudyID.Text;
                selfStudy.Request = requests;
                selfStudy.Details = details;
                cSelfStudy.Update(sub_id, selfstudyId, selfStudy);
                MessageBox.Show("Sửa thông tin thành công");
                this.Dispose();
                UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_container, sub_id);
                cMain.loadUC(pnl_container, uCSelfStudies);
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UCSelfStudies uCSelfStudies = new UCSelfStudies(pnl_container, sub_id);
            cMain.loadUC(pnl_container, uCSelfStudies);
        }
    }
}
