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
    public partial class UCDetailedOutlineEdit : UserControl
    {
        private string isAdmin;
        private CDetailedOutline cDetailedOutline = new CDetailedOutline();
        private List<string> descriptions = new List<string>();
        private List<string> studentDuties = new List<string>();
        private List<string> learningMaterials = new List<string>();
        private List<string> scientificEthics = new List<string>();
        private Panel pnl_container;
        private string sub_id;
        private DetailedOutlines detailed = new DetailedOutlines();

        private int countdescription;
        private int countSD;
        private int countLM;
        private int countSE;


        private int maxcountdescription;
        private int maxcountSD;
        private int maxcountLM;
        private int maxcountSE;


        private int mincountdescription;
        private int mincountSD;
        private int mincountLM;
        private int mincountSE;
        public UCDetailedOutlineEdit(Panel pnl_container, string subid, string isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
            this.sub_id = subid;
            this.pnl_container = pnl_container;
            countdescription = 0;
            countLM = 0;
            countSD = 0;
            countSE = 0;
            detailed = cDetailedOutline.findfromsubject(subid);
            this.txt_description.Text = detailed.Description[0];
            this.txt_LM.Text = detailed.Learning_Materials[0];
            this.txt_SD.Text = detailed.Student_Duties[0];
            this.txt_SE.Text = detailed.Scientific_Ethics[0];
            descriptions = detailed.Description;
            learningMaterials = detailed.Learning_Materials;
            studentDuties = detailed.Student_Duties;
            scientificEthics = detailed.Scientific_Ethics;

            maxcountdescription = detailed.Description.Count();
            if (maxcountdescription != 0)
                mincountdescription = 1;
            else
                mincountdescription = 0;

            maxcountLM = detailed.Learning_Materials.Count();
            if (maxcountLM != 0)
                mincountLM = 1;
            else
                mincountLM = 0;

            maxcountSD = detailed.Student_Duties.Count();
            if (maxcountSD != 0)
                mincountSD = 1;
            else
                mincountSD = 0;

            maxcountSE = detailed.Scientific_Ethics.Count();
            if (maxcountSE != 0)
                mincountSE = 1;
            else
                mincountSE = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Dispose();
            UCDetailedOutline uC = new UCDetailedOutline(pnl_container, sub_id, isAdmin);
            cMain.loadUC(pnl_container, uC);
        }

        private void btn_preDescription_Click(object sender, EventArgs e)
        {
            if (countdescription > mincountdescription - 1)
            {
                this.txt_description.Text = descriptions[countdescription - 1];
                countdescription--;
                lbl_countDescription.Text = (countdescription + 1).ToString();
            }
            else
                this.txt_description.Text = descriptions[0];
        }

        private void btn_editDescription_Click(object sender, EventArgs e)
        {
            if (txt_description.Text != "")
            {
                descriptions[countdescription] = this.txt_description.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_nextDescription_Click(object sender, EventArgs e)
        {

            if (countdescription < maxcountdescription - 1)
            {
                this.txt_description.Text = descriptions[countdescription + 1];
                countdescription++;
                lbl_countDescription.Text = (countdescription + 1).ToString();

            }
            else
                this.txt_description.Text = descriptions[maxcountdescription - 1];
        }

        private void btn_preSD_Click(object sender, EventArgs e)
        {
            if (countSD > mincountSD - 1)
            {
                this.txt_SD.Text = studentDuties[countSD - 1];
                countSD--;
                lbl_countSD.Text = (countSD + 1).ToString();
            }
            else
                this.txt_SD.Text = studentDuties[0];
        }

        private void btn_editSD_Click(object sender, EventArgs e)
        {

            if (txt_SD.Text != "")
            {
                studentDuties[countSD] = this.txt_SD.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_nextSD_Click(object sender, EventArgs e)
        {
            if (countSD < maxcountSD - 1)
            {
                this.txt_SD.Text = studentDuties[countSD + 1];
                countSD++;
                lbl_countSD.Text = (countSD + 1).ToString();

            }
            else
                this.txt_SD.Text = studentDuties[maxcountSD - 1];
        }

        private void btn_preLM_Click(object sender, EventArgs e)
        {
            if (countLM > mincountLM - 1)
            {
                this.txt_LM.Text = learningMaterials[countLM - 1];
                countLM--;
                lbl_countLM.Text = (countLM + 1).ToString();
            }
            else
                this.txt_LM.Text = learningMaterials[0];
        }

        private void btn_editLM_Click(object sender, EventArgs e)
        {

            if (txt_LM.Text != "")
            {
                learningMaterials[countLM] = this.txt_LM.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_nextLM_Click(object sender, EventArgs e)
        {
            if (countLM < maxcountLM - 1)
            {
                this.txt_LM.Text = learningMaterials[countLM + 1];
                countLM++;
                lbl_countLM.Text = (countLM + 1).ToString();

            }
            else
                this.txt_LM.Text = learningMaterials[maxcountLM - 1];
        }

        private void btn_preSE_Click(object sender, EventArgs e)
        {
            if (countSE > mincountSE - 1)
            {
                this.txt_SE.Text = scientificEthics[countSE - 1];
                countSE--;
                lbl_countSE.Text = (countSE + 1).ToString();
            }
            else
                this.txt_SE.Text = scientificEthics[0];
        }

        private void btn_editSE_Click(object sender, EventArgs e)
        {

            if (txt_SE.Text != "")
            {
                scientificEthics[countSE] = this.txt_SE.Text;
                MessageBox.Show("Sửa yêu cầu thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_nextSE_Click(object sender, EventArgs e)
        {
            if (countSE < maxcountSE - 1)
            {
                this.txt_SE.Text = scientificEthics[countSE + 1];
                countSE++;
                lbl_countSE.Text = (countSE + 1).ToString();

            }
            else
                this.txt_SE.Text = scientificEthics[maxcountSE - 1];
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_description.Text != "" && txt_LM.Text != "" && txt_SD.Text != "" && txt_SE.Text != "")
            {
                detailed.Description = descriptions;
                detailed.Learning_Materials = learningMaterials;
                detailed.Scientific_Ethics = scientificEthics;
                detailed.Student_Duties = studentDuties;
                cDetailedOutline.Update(sub_id, detailed);
                MessageBox.Show("Sửa thông tin thành công");
                this.Dispose();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
    }
}
