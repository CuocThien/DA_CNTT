﻿namespace DA_CNTT
{
    partial class UCDetailedOutline
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
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.btn_edit = new Guna.UI.WinForms.GunaButton();
            this.pnl_content = new Guna.UI.WinForms.GunaPanel();
            this.dgv_DetailedOutline = new Guna.UI.WinForms.GunaDataGridView();
            this.col_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Student_Duties = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Learning_Materials = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Scientific_Ethics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Control.SuspendLayout();
            this.pnl_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailedOutline)).BeginInit();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.btn_delete);
            this.pnl_Control.Controls.Add(this.btn_Add);
            this.pnl_Control.Controls.Add(this.btn_edit);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(1032, 80);
            this.pnl_Control.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.AnimationHoverSpeed = 0.07F;
            this.btn_delete.AnimationSpeed = 0.03F;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BackgroundImage = global::DA_CNTT.Properties.Resources.delete;
            this.btn_delete.BaseColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderSize = 3;
            this.btn_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_delete.Enabled = false;
            this.btn_delete.FocusedColor = System.Drawing.Color.Empty;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Magenta;
            this.btn_delete.Image = null;
            this.btn_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_delete.Location = new System.Drawing.Point(786, 18);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_delete.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_delete.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_delete.OnHoverImage = null;
            this.btn_delete.OnPressedColor = System.Drawing.Color.Black;
            this.btn_delete.Radius = 10;
            this.btn_delete.Size = new System.Drawing.Size(138, 44);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = global::DA_CNTT.Properties.Resources.addl1;
            this.btn_Add.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderSize = 3;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Magenta;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(138, 18);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(149, 44);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AnimationHoverSpeed = 0.07F;
            this.btn_edit.AnimationSpeed = 0.03F;
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = global::DA_CNTT.Properties.Resources.sua;
            this.btn_edit.BaseColor = System.Drawing.Color.Transparent;
            this.btn_edit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_edit.BorderSize = 3;
            this.btn_edit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_edit.Enabled = false;
            this.btn_edit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.Color.Magenta;
            this.btn_edit.Image = null;
            this.btn_edit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_edit.Location = new System.Drawing.Point(448, 18);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_edit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_edit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_edit.OnHoverImage = null;
            this.btn_edit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_edit.Radius = 10;
            this.btn_edit.Size = new System.Drawing.Size(146, 44);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Controls.Add(this.dgv_DetailedOutline);
            this.pnl_content.Location = new System.Drawing.Point(2, 83);
            this.pnl_content.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(998, 437);
            this.pnl_content.TabIndex = 1;
            // 
            // dgv_DetailedOutline
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DetailedOutline.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DetailedOutline.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_DetailedOutline.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DetailedOutline.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DetailedOutline.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetailedOutline.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DetailedOutline.ColumnHeadersHeight = 42;
            this.dgv_DetailedOutline.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Description,
            this.col_Student_Duties,
            this.col_Learning_Materials,
            this.col_Scientific_Ethics});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetailedOutline.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_DetailedOutline.EnableHeadersVisualStyles = false;
            this.dgv_DetailedOutline.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailedOutline.Location = new System.Drawing.Point(0, 0);
            this.dgv_DetailedOutline.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_DetailedOutline.Name = "dgv_DetailedOutline";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DetailedOutline.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_DetailedOutline.RowHeadersVisible = false;
            this.dgv_DetailedOutline.RowHeadersWidth = 82;
            this.dgv_DetailedOutline.RowTemplate.Height = 33;
            this.dgv_DetailedOutline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DetailedOutline.Size = new System.Drawing.Size(998, 437);
            this.dgv_DetailedOutline.TabIndex = 1;
            this.dgv_DetailedOutline.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_DetailedOutline.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_DetailedOutline.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailedOutline.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_DetailedOutline.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_DetailedOutline.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_DetailedOutline.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_DetailedOutline.ThemeStyle.ReadOnly = false;
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_DetailedOutline.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_DetailedOutline.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DetailedOutline_CellClick);
            // 
            // col_Description
            // 
            this.col_Description.FillWeight = 25F;
            this.col_Description.HeaderText = "Mô tả";
            this.col_Description.MinimumWidth = 40;
            this.col_Description.Name = "col_Description";
            // 
            // col_Student_Duties
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Student_Duties.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Student_Duties.FillWeight = 25F;
            this.col_Student_Duties.HeaderText = "Nhiệm vụ của SV";
            this.col_Student_Duties.MinimumWidth = 10;
            this.col_Student_Duties.Name = "col_Student_Duties";
            // 
            // col_Learning_Materials
            // 
            this.col_Learning_Materials.FillWeight = 25F;
            this.col_Learning_Materials.HeaderText = "Công cụ học tập";
            this.col_Learning_Materials.MinimumWidth = 10;
            this.col_Learning_Materials.Name = "col_Learning_Materials";
            // 
            // col_Scientific_Ethics
            // 
            this.col_Scientific_Ethics.FillWeight = 25F;
            this.col_Scientific_Ethics.HeaderText = "Đạo đức khoa học";
            this.col_Scientific_Ethics.MinimumWidth = 10;
            this.col_Scientific_Ethics.Name = "col_Scientific_Ethics";
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.pnl_Control);
            this.pnl_container.Controls.Add(this.pnl_content);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(1032, 588);
            this.pnl_container.TabIndex = 3;
            // 
            // UCDetailedOutline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_container);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UCDetailedOutline";
            this.Size = new System.Drawing.Size(1032, 588);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetailedOutline)).EndInit();
            this.pnl_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_edit;
        private Guna.UI.WinForms.GunaPanel pnl_content;
        private Guna.UI.WinForms.GunaDataGridView dgv_DetailedOutline;
        private Guna.UI.WinForms.GunaPanel pnl_container;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Student_Duties;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Learning_Materials;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Scientific_Ethics;
    }
}
