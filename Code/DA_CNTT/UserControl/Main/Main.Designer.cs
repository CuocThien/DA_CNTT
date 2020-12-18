namespace DA_CNTT
{
    partial class Main
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
            this.txt_Password = new Guna.UI.WinForms.GunaTextBox();
            this.txt_Username = new Guna.UI.WinForms.GunaTextBox();
            this.btn_Login = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.Transparent;
            this.txt_Password.BaseColor = System.Drawing.Color.White;
            this.txt_Password.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Password.BorderSize = 3;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Password.FocusedBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Password.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(338, 531);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Radius = 15;
            this.txt_Password.Size = new System.Drawing.Size(799, 83);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.Transparent;
            this.txt_Username.BaseColor = System.Drawing.Color.White;
            this.txt_Username.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Username.BorderSize = 3;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Username.FocusedBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Username.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(338, 339);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.Radius = 15;
            this.txt_Username.Size = new System.Drawing.Size(799, 83);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Login
            // 
            this.btn_Login.AnimationHoverSpeed = 0.07F;
            this.btn_Login.AnimationSpeed = 0.03F;
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Login.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Login.BorderSize = 3;
            this.btn_Login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.Magenta;
            this.btn_Login.Image = null;
            this.btn_Login.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Login.Location = new System.Drawing.Point(572, 672);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Login.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Login.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.btn_Login.OnHoverImage = null;
            this.btn_Login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Login.Radius = 10;
            this.btn_Login.Size = new System.Drawing.Size(330, 84);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Magenta;
            this.gunaLabel1.Location = new System.Drawing.Point(136, 548);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(196, 50);
            this.gunaLabel1.TabIndex = 20;
            this.gunaLabel1.Text = "Mật khẩu:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Magenta;
            this.gunaLabel2.Location = new System.Drawing.Point(44, 358);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(288, 50);
            this.gunaLabel2.TabIndex = 20;
            this.gunaLabel2.Text = "Tên đăng nhập:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Magenta;
            this.gunaLabel3.Location = new System.Drawing.Point(499, 155);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(461, 92);
            this.gunaLabel3.TabIndex = 20;
            this.gunaLabel3.Text = "ĐĂNG NHẬP";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1474, 1429);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Password);
            this.Name = "Main";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txt_Password;
        private Guna.UI.WinForms.GunaTextBox txt_Username;
        private Guna.UI.WinForms.GunaButton btn_Login;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}