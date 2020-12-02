﻿namespace DA_CNTT
{
    partial class UCChapters
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btn_delete = new Guna.UI.WinForms.GunaButton();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.btn_edit = new Guna.UI.WinForms.GunaButton();
            this.dgv_Chapters = new Guna.UI.WinForms.GunaDataGridView();
            this.col_ChapterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChapterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chapters)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.btn_delete);
            this.gunaPanel1.Controls.Add(this.btn_Add);
            this.gunaPanel1.Controls.Add(this.btn_edit);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(2000, 174);
            this.gunaPanel1.TabIndex = 0;
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
            // 
            // dgv_Chapters
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Chapters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Chapters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Chapters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Chapters.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Chapters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Chapters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Chapters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Chapters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Chapters.ColumnHeadersHeight = 42;
            this.dgv_Chapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ChapterID,
            this.col_ChapterName,
            this.col_Detail});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Chapters.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Chapters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Chapters.EnableHeadersVisualStyles = false;
            this.dgv_Chapters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Chapters.Location = new System.Drawing.Point(0, 174);
            this.dgv_Chapters.Name = "dgv_Chapters";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Chapters.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Chapters.RowHeadersVisible = false;
            this.dgv_Chapters.RowHeadersWidth = 82;
            this.dgv_Chapters.RowTemplate.Height = 33;
            this.dgv_Chapters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Chapters.Size = new System.Drawing.Size(2000, 825);
            this.dgv_Chapters.TabIndex = 1;
            this.dgv_Chapters.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Chapters.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Chapters.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Chapters.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Chapters.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Chapters.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Chapters.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Chapters.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Chapters.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Chapters.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Chapters.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Chapters.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Chapters.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Chapters.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_Chapters.ThemeStyle.ReadOnly = false;
            this.dgv_Chapters.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Chapters.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Chapters.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Chapters.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Chapters.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_Chapters.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Chapters.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // col_ChapterID
            // 
            this.col_ChapterID.HeaderText = "Chương";
            this.col_ChapterID.MinimumWidth = 10;
            this.col_ChapterID.Name = "col_ChapterID";
            // 
            // col_ChapterName
            // 
            this.col_ChapterName.FillWeight = 400F;
            this.col_ChapterName.HeaderText = "Tên chương";
            this.col_ChapterName.MinimumWidth = 10;
            this.col_ChapterName.Name = "col_ChapterName";
            // 
            // col_Detail
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Detail.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Detail.FillWeight = 500F;
            this.col_Detail.HeaderText = "Chi tiết";
            this.col_Detail.MinimumWidth = 10;
            this.col_Detail.Name = "col_Detail";
            // 
            // UCChapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_Chapters);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "UCChapters";
            this.Size = new System.Drawing.Size(2000, 999);
            this.gunaPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Chapters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton btn_delete;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private Guna.UI.WinForms.GunaButton btn_edit;
        private Guna.UI.WinForms.GunaDataGridView dgv_Chapters;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChapterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChapterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Detail;
    }
}
