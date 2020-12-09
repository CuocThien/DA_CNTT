using DA_CNTT.UCcontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DA_CNTT;
using DA_CNTT.Controllers;

namespace DA_CNTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pb_Title.Image = Image.FromFile(@"..\..\img\spkt.png");
            this.pb_Title.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_logo.Image = Image.FromFile(@"..\..\img\cntt.png");
            this.pb_logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_IntroG_Click(object sender, EventArgs e)
        {
            UCIntroGroup ucIntroG = new UCIntroGroup();
            cMain.loadUC(this.pnl_content, ucIntroG);
        }

        private void btn_IntroPro_Click(object sender, EventArgs e)
        {
            UCIntroPro uCIntroPro = new UCIntroPro();
            cMain.loadUC(this.pnl_content, uCIntroPro);
        }

        private void btn_CnttBefore18_Click(object sender, EventArgs e)
        {
            UCCnttBefore18 uCCnttBefore18 = new UCCnttBefore18();
            cMain.loadUC(this.pnl_content, uCCnttBefore18);
        }
    }
}
