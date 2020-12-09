namespace DA_CNTT
{
    partial class UCCourseGoals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.pnl_container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.btn_edit = new Guna.UI.WinForms.GunaButton();
            this.pnl_content = new Guna.UI.WinForms.GunaPanel();
            this.dgv_CourseGoals = new Guna.UI.WinForms.GunaDataGridView();
            this.col_CourseGoalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CourseGoalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDCDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_IDCTDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            this.pnl_container.SuspendLayout();
            this.pnl_Control.SuspendLayout();
            this.pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseGoals)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.pnl_container);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(2000, 999);
            this.gunaPanel1.TabIndex = 0;
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
            this.pnl_content.Controls.Add(this.dgv_CourseGoals);
            this.pnl_content.Location = new System.Drawing.Point(3, 159);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(1997, 840);
            this.pnl_content.TabIndex = 1;
            // 
            // dgv_CourseGoals
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_CourseGoals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CourseGoals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_CourseGoals.BackgroundColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_CourseGoals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_CourseGoals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CourseGoals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_CourseGoals.ColumnHeadersHeight = 42;
            this.dgv_CourseGoals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_CourseGoalID,
            this.col_CourseGoalName,
            this.col_IDCDR,
            this.col_IDCTDT});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CourseGoals.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_CourseGoals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CourseGoals.EnableHeadersVisualStyles = false;
            this.dgv_CourseGoals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CourseGoals.Location = new System.Drawing.Point(0, 0);
            this.dgv_CourseGoals.Name = "dgv_CourseGoals";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_CourseGoals.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_CourseGoals.RowHeadersVisible = false;
            this.dgv_CourseGoals.RowHeadersWidth = 82;
            this.dgv_CourseGoals.RowTemplate.Height = 33;
            this.dgv_CourseGoals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CourseGoals.Size = new System.Drawing.Size(1997, 840);
            this.dgv_CourseGoals.TabIndex = 1;
            this.dgv_CourseGoals.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_CourseGoals.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_CourseGoals.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_CourseGoals.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_CourseGoals.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_CourseGoals.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_CourseGoals.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_CourseGoals.ThemeStyle.ReadOnly = false;
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_CourseGoals.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_CourseGoals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CourseGoals_CellClick);
            // 
            // col_CourseGoalID
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_CourseGoalID.DefaultCellStyle = dataGridViewCellStyle11;
            this.col_CourseGoalID.FillWeight = 10F;
            this.col_CourseGoalID.HeaderText = "Mục tiêu";
            this.col_CourseGoalID.MinimumWidth = 10;
            this.col_CourseGoalID.Name = "col_CourseGoalID";
            // 
            // col_CourseGoalName
            // 
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_CourseGoalName.DefaultCellStyle = dataGridViewCellStyle12;
            this.col_CourseGoalName.FillWeight = 50F;
            this.col_CourseGoalName.HeaderText = "Mô tả";
            this.col_CourseGoalName.MinimumWidth = 10;
            this.col_CourseGoalName.Name = "col_CourseGoalName";
            // 
            // col_IDCDR
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IDCDR.DefaultCellStyle = dataGridViewCellStyle13;
            this.col_IDCDR.FillWeight = 20F;
            this.col_IDCDR.HeaderText = "Chuẩn đầu ra học phần";
            this.col_IDCDR.MinimumWidth = 10;
            this.col_IDCDR.Name = "col_IDCDR";
            // 
            // col_IDCTDT
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_IDCTDT.DefaultCellStyle = dataGridViewCellStyle14;
            this.col_IDCTDT.FillWeight = 15F;
            this.col_IDCTDT.HeaderText = "Chuẩn đầu ra CTDT";
            this.col_IDCTDT.MinimumWidth = 10;
            this.col_IDCTDT.Name = "col_IDCTDT";
            // 
            // UCCourseGoals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UCCourseGoals";
            this.Size = new System.Drawing.Size(2000, 999);
            this.Load += new System.EventHandler(this.UCCourseGoals_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.pnl_container.ResumeLayout(false);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CourseGoals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel pnl_container;
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_edit;
        private Guna.UI.WinForms.GunaPanel pnl_content;
        private Guna.UI.WinForms.GunaDataGridView dgv_CourseGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CourseGoalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CourseGoalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDCDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDCTDT;
    }
}
