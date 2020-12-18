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
    public partial class UCChaptersAdd : UserControl
    {
        private string isAdmin;
        private CChapters cChapters = new CChapters();
        private List<string> details = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        private int count;
        public UCChaptersAdd(string id, Panel pnl_container, string isAdmin)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            count = 0;
            this.isAdmin = isAdmin;
        }

        private void btn_AddDetail_Click(object sender, EventArgs e)
        {
            if (this.txt_Detail.Text != "")
            {
                var detail = this.txt_Detail.Text;
                details.Add(detail);
                count++;
                lbl_count.Text = count.ToString();
                MessageBox.Show("Thêm chi tiết thành công");
                this.txt_Detail.Text = "";
            }
            else
                MessageBox.Show("Vui lòng điền chi tiết vào");
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ChapterID.Text != "" && txt_ChapterName.Text != "" && count != 0)
            {
                var chapterID = this.txt_ChapterID.Text;
                var chapterName = this.txt_ChapterName.Text;
                cChapters.addChapter(sub_id, chapterID, chapterName, details);
                this.txt_ChapterID.Text = "";
                this.txt_ChapterName.Text = "";
                MessageBox.Show("Thành Công");


                this.txt_ChapterID.Text = "";
                this.txt_ChapterName.Text = "";

                this.Dispose();
                UCChaptersAdd uCChaptersAdd = new UCChaptersAdd(sub_id, pnl_container,isAdmin);
                cMain.loadUC(pnl_container, uCChaptersAdd);
            }
            else if (count == 0)
            {
                MessageBox.Show("Vui lòng điền chi tiết trước");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, sub_id,isAdmin);
            this.Dispose();
            cMain.loadUC(pnl_container, uCChapters);
        }
    }
}
