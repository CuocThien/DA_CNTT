namespace DA_CNTT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_IntroGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_Title = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_Title = new Guna.UI.WinForms.GunaPanel();
            this.pb_logo = new Guna.UI.WinForms.GunaPictureBox();
            this.pnl_Container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Menu = new Guna.UI.WinForms.GunaPanel();
            this.pnl_content = new Guna.UI.WinForms.GunaPanel();
            this.ms_Menu = new System.Windows.Forms.MenuStrip();
            this.btn_Gioithieu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_IntroG = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_IntroPro = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ctdt = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_inUni = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Cntt = new System.Windows.Forms.ToolStripMenuItem();
            this.tRƯỚCK18ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.k18ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.sAUK18ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_IntroProj = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).BeginInit();
            this.pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.ms_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IntroGroup
            // 
            this.btn_IntroGroup.Name = "btn_IntroGroup";
            this.btn_IntroGroup.Size = new System.Drawing.Size(327, 44);
            this.btn_IntroGroup.Text = "Giới thiệu Nhóm";
            // 
            // pb_Title
            // 
            this.pb_Title.BaseColor = System.Drawing.Color.White;
            this.pb_Title.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Title.InitialImage = null;
            this.pb_Title.Location = new System.Drawing.Point(0, 0);
            this.pb_Title.Name = "pb_Title";
            this.pb_Title.Size = new System.Drawing.Size(2092, 200);
            this.pb_Title.TabIndex = 0;
            this.pb_Title.TabStop = false;
            // 
            // pnl_Title
            // 
            this.pnl_Title.BackColor = System.Drawing.Color.White;
            this.pnl_Title.Controls.Add(this.pb_logo);
            this.pnl_Title.Controls.Add(this.pb_Title);
            this.pnl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Title.Location = new System.Drawing.Point(0, 0);
            this.pnl_Title.Name = "pnl_Title";
            this.pnl_Title.Size = new System.Drawing.Size(2374, 200);
            this.pnl_Title.TabIndex = 0;
            // 
            // pb_logo
            // 
            this.pb_logo.BaseColor = System.Drawing.Color.White;
            this.pb_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_logo.Location = new System.Drawing.Point(2092, 0);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(282, 200);
            this.pb_logo.TabIndex = 1;
            this.pb_logo.TabStop = false;
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.White;
            this.pnl_Container.Controls.Add(this.pnl_content);
            this.pnl_Container.Controls.Add(this.pnl_Menu);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(0, 200);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(2374, 1075);
            this.pnl_Container.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.ms_Menu);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(2374, 76);
            this.pnl_Menu.TabIndex = 0;
            // 
            // pnl_content
            // 
            this.pnl_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_content.Location = new System.Drawing.Point(0, 76);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(2374, 999);
            this.pnl_content.TabIndex = 1;
            // 
            // ms_Menu
            // 
            this.ms_Menu.AllowDrop = true;
            this.ms_Menu.AutoSize = false;
            this.ms_Menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ms_Menu.GripMargin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.ms_Menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Gioithieu,
            this.btn_ctdt});
            this.ms_Menu.Location = new System.Drawing.Point(0, 0);
            this.ms_Menu.Name = "ms_Menu";
            this.ms_Menu.Size = new System.Drawing.Size(2374, 76);
            this.ms_Menu.TabIndex = 0;
            this.ms_Menu.Text = "menuStrip1";
            // 
            // btn_Gioithieu
            // 
            this.btn_Gioithieu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Gioithieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_IntroG,
            this.btn_IntroPro});
            this.btn_Gioithieu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gioithieu.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.btn_Gioithieu.Name = "btn_Gioithieu";
            this.btn_Gioithieu.Size = new System.Drawing.Size(176, 72);
            this.btn_Gioithieu.Text = "GIỚI THIỆU";
            // 
            // btn_IntroG
            // 
            this.btn_IntroG.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_IntroG.Name = "btn_IntroG";
            this.btn_IntroG.Size = new System.Drawing.Size(385, 46);
            this.btn_IntroG.Text = "GIỚI THIỆU NHÓM";
            this.btn_IntroG.Click += new System.EventHandler(this.btn_IntroG_Click);
            // 
            // btn_IntroPro
            // 
            this.btn_IntroPro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_IntroPro.Name = "btn_IntroPro";
            this.btn_IntroPro.Size = new System.Drawing.Size(385, 46);
            this.btn_IntroPro.Text = "GIỚI THIỆU ĐỀ TÀI";
            this.btn_IntroPro.Click += new System.EventHandler(this.btn_IntroPro_Click);
            // 
            // btn_ctdt
            // 
            this.btn_ctdt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ctdt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_inUni});
            this.btn_ctdt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ctdt.Name = "btn_ctdt";
            this.btn_ctdt.Size = new System.Drawing.Size(367, 72);
            this.btn_ctdt.Text = "CHƯƠNG TRÌNH ĐÀO TẠO";
            // 
            // btn_inUni
            // 
            this.btn_inUni.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_inUni.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cntt});
            this.btn_inUni.Name = "btn_inUni";
            this.btn_inUni.Size = new System.Drawing.Size(262, 46);
            this.btn_inUni.Text = "ĐẠI HỌC";
            // 
            // btn_Cntt
            // 
            this.btn_Cntt.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Cntt.Name = "btn_Cntt";
            this.btn_Cntt.Size = new System.Drawing.Size(463, 46);
            this.btn_Cntt.Text = "CÔNG NGHỆ THÔNG TIN";
            this.btn_Cntt.Click += new System.EventHandler(this.btn_Cntt_Click);
            // 
            // tRƯỚCK18ToolStripMenuItem2
            // 
            this.tRƯỚCK18ToolStripMenuItem2.Name = "tRƯỚCK18ToolStripMenuItem2";
            this.tRƯỚCK18ToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.tRƯỚCK18ToolStripMenuItem2.Text = "TRƯỚC K18";
            // 
            // k18ToolStripMenuItem2
            // 
            this.k18ToolStripMenuItem2.Name = "k18ToolStripMenuItem2";
            this.k18ToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.k18ToolStripMenuItem2.Text = "K18";
            // 
            // sAUK18ToolStripMenuItem2
            // 
            this.sAUK18ToolStripMenuItem2.Name = "sAUK18ToolStripMenuItem2";
            this.sAUK18ToolStripMenuItem2.Size = new System.Drawing.Size(359, 44);
            this.sAUK18ToolStripMenuItem2.Text = "SAU K18";
            // 
            // btn_IntroProj
            // 
            this.btn_IntroProj.Name = "btn_IntroProj";
            this.btn_IntroProj.Size = new System.Drawing.Size(327, 44);
            this.btn_IntroProj.Text = "Giới thiệu Đề tài";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2374, 1275);
            this.Controls.Add(this.pnl_Container);
            this.Controls.Add(this.pnl_Title);
            this.MainMenuStrip = this.ms_Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).EndInit();
            this.pnl_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.ms_Menu.ResumeLayout(false);
            this.ms_Menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem btn_IntroGroup;
        private Guna.UI.WinForms.GunaPictureBox pb_Title;
        private Guna.UI.WinForms.GunaPanel pnl_Title;
        private Guna.UI.WinForms.GunaPictureBox pb_logo;
        private Guna.UI.WinForms.GunaPanel pnl_Container;
        private Guna.UI.WinForms.GunaPanel pnl_content;
        private Guna.UI.WinForms.GunaPanel pnl_Menu;
        private System.Windows.Forms.MenuStrip ms_Menu;
        private System.Windows.Forms.ToolStripMenuItem btn_Gioithieu;
        private System.Windows.Forms.ToolStripMenuItem btn_IntroG;
        private System.Windows.Forms.ToolStripMenuItem btn_IntroPro;
        private System.Windows.Forms.ToolStripMenuItem btn_ctdt;
        private System.Windows.Forms.ToolStripMenuItem btn_inUni;
        private System.Windows.Forms.ToolStripMenuItem btn_Cntt;
        private System.Windows.Forms.ToolStripMenuItem tRƯỚCK18ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem k18ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sAUK18ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem btn_IntroProj;
    }
}

