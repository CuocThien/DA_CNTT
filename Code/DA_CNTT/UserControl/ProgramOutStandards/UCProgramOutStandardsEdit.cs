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
    public partial class UCProgramOutStandardsEdit : UserControl
    {
        private string subId;
        private Panel pnl_container;
        private CProgramOutStandards cPOS = new CProgramOutStandards();
        private string POSId;
        private int count;
        private int min;
        private int max;
        private OutCome outcome;
        private List<string> CDIOs = new List<string>();
        public UCProgramOutStandardsEdit(string subId, string POSId, Panel pnl_container)
        {
            InitializeComponent();
            count = 0;
            this.subId = subId;
            this.POSId = POSId;
            this.pnl_container = pnl_container;
            outcome = cPOS.findfromsubject(subId).OutComes.Where(c => c.ID_CDR == POSId).SingleOrDefault();
            this.txt_CDRID.Text = outcome.ID_CDR;
            this.txt_Description.Text = outcome.Description_CDR;
            this.txt_CDR.Text = outcome.ID_CDIO[0].ToString();

            CDIOs = outcome.ID_CDIO;
            max = outcome.ID_CDIO.Count();
            if (max != 0)
                min = 1;
            else
                min = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_container, subId);
            this.Dispose();
            cMain.loadUC(pnl_container, uCProgramOutStandards);
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            if (count > min - 1)
            {
                this.txt_CDR.Text = outcome.ID_CDIO[count - 1];
                count--;
                lbl_countCDIO.Text = (count + 1).ToString();
            }
            else
                this.txt_CDR.Text = outcome.ID_CDIO[0];
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (count < max - 1)
            {
                this.txt_CDR.Text = outcome.ID_CDIO[count + 1];
                count++;
                lbl_countCDIO.Text = (count + 1).ToString();

            }
            else
                this.txt_CDR.Text = outcome.ID_CDIO[max - 1];
        }

        private void btn_editcdio_Click(object sender, EventArgs e)
        {
            if (txt_CDR.Text != "")
            {
                CDIOs[count] = this.txt_CDR.Text;
                MessageBox.Show("Sửa CĐR học phần thành công");
            }
            else
            {
                MessageBox.Show("Không để trống!!!");
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (txt_CDRID.Text != "" && txt_Description.Text != "" )
            {
                outcome.ID_CDR = this.txt_CDRID.Text;
                outcome.Description_CDR = this.txt_Description.Text;
                outcome.ID_CDIO = CDIOs;
                cPOS.Update(subId, POSId, outcome);
                MessageBox.Show("Sửa thông tin thành công");
                UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_container,subId);
                cMain.loadUC(pnl_container, uCProgramOutStandards);
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }
    }
}
