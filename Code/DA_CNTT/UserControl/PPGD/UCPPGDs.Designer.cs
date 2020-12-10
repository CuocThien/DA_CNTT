namespace DA_CNTT
{
    partial class UCPPGDs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_PPGDs = new Guna.UI.WinForms.GunaDataGridView();
            this.col_IDPPGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.btn_edit = new Guna.UI.WinForms.GunaButton();
            this.pnl_content = new Guna.UI.WinForms.GunaPanel();
            this.pnl_container = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PPGDs)).BeginInit();
            this.pnl_Control.SuspendLayout();
            this.pnl_content.SuspendLayout();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_PPGDs
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_PPGDs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_PPGDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PPGDs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_PPGDs.BackgroundColor = System.Drawing.Color.White;
            this.dgv_PPGDs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_PPGDs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_PPGDs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PPGDs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_PPGDs.ColumnHeadersHeight = 42;
            this.dgv_PPGDs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDPPGD,
            this.col_Detail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PPGDs.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_PPGDs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_PPGDs.EnableHeadersVisualStyles = false;
            this.dgv_PPGDs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_PPGDs.Location = new System.Drawing.Point(0, 0);
            this.dgv_PPGDs.Name = "dgv_PPGDs";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_PPGDs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_PPGDs.RowHeadersVisible = false;
            this.dgv_PPGDs.RowHeadersWidth = 82;
            this.dgv_PPGDs.RowTemplate.Height = 33;
            this.dgv_PPGDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_PPGDs.Size = new System.Drawing.Size(1997, 840);
            this.dgv_PPGDs.TabIndex = 1;
            this.dgv_PPGDs.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_PPGDs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PPGDs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_PPGDs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_PPGDs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_PPGDs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_PPGDs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PPGDs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_PPGDs.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_PPGDs.ThemeStyle.ReadOnly = false;
            this.dgv_PPGDs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_PPGDs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_PPGDs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_PPGDs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_PPGDs.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_PPGDs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_PPGDs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_PPGDs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PPGDs_CellClick);
            // 
            // col_IDPPGD
            // 
            this.col_IDPPGD.FillWeight = 30F;
            this.col_IDPPGD.HeaderText = "Mã PPGD";
            this.col_IDPPGD.MinimumWidth = 10;
            this.col_IDPPGD.Name = "col_IDPPGD";
            // 
            // col_Detail
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Detail.FillWeight = 70F;
            this.col_Detail.HeaderText = "Chi tiết";
            this.col_Detail.MinimumWidth = 10;
            this.col_Detail.Name = "col_Detail";
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.btn_delete);
            this.pnl_Control.Controls.Add(this.btn_Add);
            this.pnl_Control.Controls.Add(this.btn_edit);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(2000, 153);
            this.pnl_Control.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_delete.BorderSize = 3;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.Enabled = false;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Magenta;
            this.btn_delete.Image = null;
            this.btn_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete.Location = new System.Drawing.Point(1551, 45);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Radius = 10;
            this.btn_delete.Size = new System.Drawing.Size(330, 84);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "XÓA";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Add.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Add.BorderSize = 3;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Magenta;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(165, 45);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(330, 84);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BaseColor = System.Drawing.Color.LightSkyBlue;
            this.btn_edit.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.BorderSize = 3;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_edit.Enabled = false;
            this.btn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Magenta;
            this.btn_edit.Image = null;
            this.btn_edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_edit.Location = new System.Drawing.Point(835, 45);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.DarkOrange;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.DeepPink;
            this.btn_edit.OnHoverImage = null;
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Radius = 10;
            this.btn_edit.Size = new System.Drawing.Size(330, 84);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "SỬA";
            this.btn_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.dgv_PPGDs);
            this.pnl_content.Location = new System.Drawing.Point(3, 159);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1997, 840);
            this.pnl_content.TabIndex = 1;
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.pnl_Control);
            this.pnl_container.Controls.Add(this.pnl_content);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(2000, 999);
            this.pnl_container.TabIndex = 1;
            // 
            // UCPPGDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_container);
            this.Name = "UCPPGDs";
            this.Size = new System.Drawing.Size(2000, 999);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PPGDs)).EndInit();
            this.pnl_Control.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgv_PPGDs;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDPPGD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Detail;
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_edit;
        private Guna.UI.WinForms.GunaPanel pnl_content;
        private Guna.UI.WinForms.GunaPanel pnl_container;
    }
}
