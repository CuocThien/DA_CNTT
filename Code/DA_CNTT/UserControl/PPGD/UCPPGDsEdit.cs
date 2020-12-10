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
    public partial class UCPPGDsEdit : UserControl
    {
        private string subId;
        private Panel pnl_container;
        private CPPGD cPPGD = new CPPGD();
        private string PPGDId;
        private int count;
        private int min;
        private int max;
        private PPGD ppgd;
        private List<string> details = new List<string>();
        public UCPPGDsEdit(string subId, string PPGDId, Panel pnl_container)
        {
            InitializeComponent();
            count = 0;
            this.subId = subId;
            this.PPGDId = PPGDId;
            this.pnl_container = pnl_container;
            ppgd = cPPGD.findfromsubject(subId).PPGD.Where(c => c.ID == PPGDId).SingleOrDefault();
            this.txt_PPGDID.Text = ppgd.ID;
            this.txt_Detail.Text = ppgd.Detail[0].ToString();

            details = ppgd.Detail;
            max = ppgd.Detail.Count();
            if (max != 0)
                min = 1;
            else
                min = 0;
        }

        private void btn_AddDetail_Click(object sender, EventArgs e)
        {

        }

        private void btn_hpprevious_Click(object sender, EventArgs e)
        {
            if (count > min - 1)
            {
                this.txt_Detail.Text = ppgd.Detail[count - 1];
                count--;
                lbl_count.Text = (count + 1).ToString();
            }
            else
                this.txt_Detail.Text = ppgd.Detail[0];
        }

        private void btn_editDetail_Click(object sender, EventArgs e)
        {
            if (txt_Detail.Text != "")
            {
                details[count] = this.txt_Detail.Text;
                MessageBox.Show("Sửa CĐR học phần thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_hpnext_Click(object sender, EventArgs e)
        {
            if (count < max - 1)
            {
                this.txt_Detail.Text = ppgd.Detail[count + 1];
                count++;
                lbl_count.Text = (count + 1).ToString();

            }
            else
                this.txt_Detail.Text = ppgd.Detail[max - 1];
        }


        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCPPGDs uCPPGDs = new UCPPGDs(pnl_container, subId);
            this.Dispose();
            cMain.loadUC(pnl_container, uCPPGDs);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_PPGDID.Text != "")
            {
                ppgd.ID = this.txt_PPGDID.Text;
                ppgd.Detail = details;
                cPPGD.Update(subId, PPGDId, ppgd);
                MessageBox.Show("Sửa thông tin thành công");
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
    }
}
