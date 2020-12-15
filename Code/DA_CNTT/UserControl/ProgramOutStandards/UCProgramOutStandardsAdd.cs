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
    public partial class UCProgramOutStandardsAdd : UserControl
    {
        private CProgramOutStandards cProgramOutStandards = new CProgramOutStandards();
        private List<string> CDIOs = new List<string>();
        private string sub_id;
        private Panel pnl_container;
        private OutCome outcome = new OutCome();
        private int count;
        public UCProgramOutStandardsAdd(string id, Panel pnl_container)
        {
            InitializeComponent();
            sub_id = id;
            this.pnl_container = pnl_container;
            count = 0;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UCProgramOutStandards uCProgramOutStandards = new UCProgramOutStandards(pnl_container, sub_id);
            this.Dispose();
            cMain.loadUC(pnl_container, uCProgramOutStandards);
        }

        private void btn_AddCDIO_Click(object sender, EventArgs e)
        {
            if (txt_CDR.Text != "")
            {
                var CDR = this.txt_CDR.Text;
                CDIOs.Add(CDR);
                MessageBox.Show("Thêm CĐR CĐIO thành công");
                this.txt_CDR.Text = "";
                count++;
                lbl_countCDIO.Text = count.ToString();
            }
            else
                MessageBox.Show("Không để trống");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_CDRID.Text != "" && txt_Description.Text != "" )
            {
                outcome.ID_CDR = this.txt_CDRID.Text;
                outcome.Description_CDR = this.txt_Description.Text;
                outcome.ID_CDIO = CDIOs;
                cProgramOutStandards.addOutcome(sub_id, outcome);
                this.txt_CDRID.Text = "";
                this.txt_Description.Text = "";
                MessageBox.Show("Thành Công");

                this.Dispose();
                UCProgramOutStandardsAdd uCProgramOutStandardsAdd = new UCProgramOutStandardsAdd(sub_id, pnl_container);
                cMain.loadUC(pnl_container, uCProgramOutStandardsAdd);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
    }
}
