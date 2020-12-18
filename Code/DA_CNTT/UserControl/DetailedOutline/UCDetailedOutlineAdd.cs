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
    public partial class UCDetailedOutlineAdd : UserControl
    {
        private string isAdmin;
        private CDetailedOutline cDetailedOutline = new CDetailedOutline();
        private List<string> descriptions = new List<string>();
        private List<string> studentDuties = new List<string>();
        private List<string> learningMaterials = new List<string>();
        private List<string> scientificEthics = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        private int countdescription;
        private int countSD;
        private int countLM;
        private int countSE;
        private DetailedOutlines detailedOutlines = new DetailedOutlines();
        public UCDetailedOutlineAdd(string id, Panel pnl_container, string isAdmin)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            countdescription = 0;
            countLM = 0;
            countSD = 0;
            countSE = 0;
            this.isAdmin = isAdmin;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCDetailedOutline uCDetailedOutline = new UCDetailedOutline(pnl_container, sub_id, isAdmin);
            cMain.loadUC(pnl_container, uCDetailedOutline);
        }

        private void btn_addDescription_Click(object sender, EventArgs e)
        {
            if (txt_description.Text != "")
            {
                var description = this.txt_description.Text;
                descriptions.Add(description);
                MessageBox.Show("Thêm mô tả thành công");
                this.txt_description.Text = "";
                countdescription++;
                lbl_countDescription.Text = countdescription.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_addLM_Click(object sender, EventArgs e)
        {
            if (txt_LM.Text != "")
            {
                var LM = this.txt_LM.Text;
                learningMaterials.Add(LM);
                MessageBox.Show("Thêm tài liệu học tập thành công");
                this.txt_LM.Text = "";
                countLM++;
                lbl_countLM.Text = countLM.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_addSD_Click(object sender, EventArgs e)
        {
            if (txt_SD.Text != "")
            {
                var SD = this.txt_SD.Text;
                studentDuties.Add(SD);
                MessageBox.Show("Thêm nhiệm vụ của sinh viên thành công");
                this.txt_SD.Text = "";
                countSD++;
                lbl_countSD.Text = countSD.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_AddSE_Click(object sender, EventArgs e)
        {
            if (txt_SE.Text != "")
            {
                var SE = this.txt_SE.Text;
                scientificEthics.Add(SE);
                MessageBox.Show("Thêm đạo đức khoa học thành công");
                this.txt_SE.Text = "";
                countSE++;
                lbl_countSE.Text = countSE.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (countSE != 0 && countSD != 0 && countLM !=0 && countdescription !=0)
            {
                detailedOutlines.Description = descriptions;
                detailedOutlines.Learning_Materials = learningMaterials;
                detailedOutlines.Scientific_Ethics = scientificEthics;
                detailedOutlines.Student_Duties = studentDuties;
                cDetailedOutline.addDetailedOutline(sub_id, detailedOutlines);
                MessageBox.Show("Thành Công");

                this.Dispose();
                UCDetailedOutline uCDetailedOutline = new UCDetailedOutline(pnl_container, sub_id,isAdmin);
                cMain.loadUC(pnl_container, uCDetailedOutline);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
