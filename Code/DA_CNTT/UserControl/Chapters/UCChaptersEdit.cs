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
    public partial class UCChaptersEdit : UserControl
    {
        private string subId;
        private Panel pnl_container;
        private CChapters cChapters = new CChapters();
        private string chapterId;
        private int count;
        private int min;
        private int max;
        private Chapter chapter;
        private List<string> details=new List<string>();
        public UCChaptersEdit(string subId, string chapterId, Panel pnl_container)
        {
            count = 0;
            InitializeComponent();
            this.subId = subId;
            this.pnl_container = pnl_container;
            chapter = cChapters.findfromsubject(subId).Chapter.Where(c=>c.ID==chapterId).SingleOrDefault();
            this.txt_ChapterID.Text = chapter.ID;
            this.chapterId = chapterId;
            this.txt_ChapterName.Text = chapter.Name;
            this.txt_Detail.Text = chapter.Detail[0].ToString();
            details = chapter.Detail;
            max = chapter.Detail.Count();
            if (max != 0)
                min = 1;
            else 
                min = 0;
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (count > min - 1)
            {
                this.txt_Detail.Text = chapter.Detail[count - 1];
                count--;
                lbl_count.Text = (count+1).ToString();
            }
            else
                this.txt_Detail.Text = chapter.Detail[0];

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (count < max - 1)
            {
                this.txt_Detail.Text = chapter.Detail[count + 1];
                count++;
                lbl_count.Text = (count+1).ToString();
            }
            else
                this.txt_Detail.Text = chapter.Detail[max - 1];

        }

        private void btn_EditDetail_Click(object sender, EventArgs e)
        {
            if (txt_Detail.Text != "")
            {
                details[count] = this.txt_Detail.Text;
                MessageBox.Show("Sửa chi tiết thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
                this.txt_Detail.Text = details[count];
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_ChapterID.Text != "" && txt_ChapterName.Text != "")
            {
                chapter.ID = this.txt_ChapterID.Text;
                chapter.Name = this.txt_ChapterName.Text;
                chapter.Detail = details;
                cChapters.Update(subId, chapterId, chapter);
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
                MessageBox.Show("Nhập đủ thông tin");

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, subId);
            this.Dispose();
            cMain.loadUC(pnl_container, uCChapters);
        }
    }
}
