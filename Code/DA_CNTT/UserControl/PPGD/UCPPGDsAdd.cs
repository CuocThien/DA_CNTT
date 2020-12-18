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
    public partial class UCPPGDsAdd : UserControl
    {
        private CPPGD cPPGD = new CPPGD();
        private List<string> details = new List<string>();
        private string sub_id;
        private PPGD ppgd = new PPGD();
        private Panel pnl_container;
        private int count;
        private string isAdmin;
        public UCPPGDsAdd(string id, Panel pnl_container, string isAdmin)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            count = 0;
            this.isAdmin = isAdmin;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCPPGDs uCPPGDs = new UCPPGDs(pnl_container, sub_id,isAdmin);
            this.Dispose();
            cMain.loadUC(pnl_container, uCPPGDs);
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
            if (txt_PPGDID.Text != "" && count != 0)
            {
                ppgd.ID = this.txt_PPGDID.Text;
                ppgd.Detail = details;
                cPPGD.addPPGD(sub_id, ppgd);
                MessageBox.Show("Thành Công");

                this.Dispose();
                UCPPGDsAdd uCPPGDsAdd = new UCPPGDsAdd(sub_id, pnl_container,isAdmin);
                cMain.loadUC(pnl_container, uCPPGDsAdd);

                this.txt_PPGDID.Text = "";
                this.txt_Detail.Text = "";
            }
            else if(count==0)
            {
                MessageBox.Show("Vui lòng điền chi tiết trước");
            }    
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
