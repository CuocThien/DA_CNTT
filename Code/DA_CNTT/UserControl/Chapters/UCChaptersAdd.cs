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
        private CChapters cChapters = new CChapters();
        private List<string> details = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        public UCChaptersAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
        }

        private void btn_AddDetail_Click(object sender, EventArgs e)
        {
            var detail = this.txt_Detail.Text;
            details.Add(detail);
            MessageBox.Show("Thành Công");
            this.txt_Detail.Text = "";
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            var chapterID = this.txt_ChapterID.Text;
            var chapterName = this.txt_ChapterName.Text;
            cChapters.addChapter(sub_id, chapterID, chapterName, details);
            this.txt_ChapterID.Text = "";
            this.txt_ChapterName.Text = "";
            MessageBox.Show("Thành Công");

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCChapters uCChapters = new UCChapters(pnl_container, sub_id);
            this.Dispose();
            cMain.loadUC(pnl_container, uCChapters);
        }
    }
}
