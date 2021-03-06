﻿namespace DA_CNTT
{
    partial class UCCnttBefore18
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.btn_Add = new Guna.UI.WinForms.GunaButton();
            this.txt_Search = new Guna.UI.WinForms.GunaTextBox();
            this.pnl_Content = new Guna.UI.WinForms.GunaPanel();
            this.dgv_Content = new Guna.UI.WinForms.GunaDataGridView();
            this.col_SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numOfCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_container = new Guna.UI.WinForms.GunaPanel();
            this.pnl_Control.SuspendLayout();
            this.pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Content)).BeginInit();
            this.pnl_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.btn_Add);
            this.pnl_Control.Controls.Add(this.txt_Search);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(2600, 125);
            this.pnl_Control.TabIndex = 2;
            // 
            // btn_Add
            // 
            this.btn_Add.AnimationHoverSpeed = 0.07F;
            this.btn_Add.AnimationSpeed = 0.03F;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BackgroundImage = global::DA_CNTT.Properties.Resources.addl;
            this.btn_Add.BaseColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderSize = 3;
            this.btn_Add.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Add.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.Magenta;
            this.btn_Add.Image = null;
            this.btn_Add.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Add.Location = new System.Drawing.Point(1916, 13);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btn_Add.OnHoverImage = null;
            this.btn_Add.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Add.Radius = 10;
            this.btn_Add.Size = new System.Drawing.Size(296, 83);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.Transparent;
            this.txt_Search.BaseColor = System.Drawing.Color.White;
            this.txt_Search.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Search.BorderSize = 3;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Search.FocusedBorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_Search.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(532, 13);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.Radius = 15;
            this.txt_Search.Size = new System.Drawing.Size(1288, 102);
            this.txt_Search.TabIndex = 0;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged_1);
            // 
            // pnl_Content
            // 
            this.pnl_Content.Controls.Add(this.dgv_Content);
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Content.Location = new System.Drawing.Point(0, 123);
            this.pnl_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(2600, 1042);
            this.pnl_Content.TabIndex = 3;
            // 
            // dgv_Content
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Content.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Content.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Content.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Content.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Content.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Content.ColumnHeadersHeight = 42;
            this.dgv_Content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SubjectID,
            this.col_SubjectName,
            this.col_numOfCredits,
            this.col_Semester});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Content.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Content.EnableHeadersVisualStyles = false;
            this.dgv_Content.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Content.Location = new System.Drawing.Point(0, 0);
            this.dgv_Content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Content.Name = "dgv_Content";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Content.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Content.RowHeadersVisible = false;
            this.dgv_Content.RowHeadersWidth = 82;
            this.dgv_Content.RowTemplate.Height = 33;
            this.dgv_Content.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Content.Size = new System.Drawing.Size(2600, 1042);
            this.dgv_Content.TabIndex = 1;
            this.dgv_Content.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_Content.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Content.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Content.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Content.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Content.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Content.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Content.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Content.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Content.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Content.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Content.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Content.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Content.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_Content.ThemeStyle.ReadOnly = false;
            this.dgv_Content.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Content.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Content.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Content.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Content.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_Content.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Content.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Content.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Content_CellClick);
            // 
            // col_SubjectID
            // 
            this.col_SubjectID.FillWeight = 20F;
            this.col_SubjectID.HeaderText = "Mã môn học";
            this.col_SubjectID.MinimumWidth = 10;
            this.col_SubjectID.Name = "col_SubjectID";
            // 
            // col_SubjectName
            // 
            this.col_SubjectName.FillWeight = 50F;
            this.col_SubjectName.HeaderText = "Tên môn học";
            this.col_SubjectName.MinimumWidth = 10;
            this.col_SubjectName.Name = "col_SubjectName";
            // 
            // col_numOfCredits
            // 
            this.col_numOfCredits.FillWeight = 15F;
            this.col_numOfCredits.HeaderText = "Số tín chỉ";
            this.col_numOfCredits.MinimumWidth = 10;
            this.col_numOfCredits.Name = "col_numOfCredits";
            // 
            // col_Semester
            // 
            this.col_Semester.FillWeight = 15F;
            this.col_Semester.HeaderText = "Học kỳ";
            this.col_Semester.MinimumWidth = 10;
            this.col_Semester.Name = "col_Semester";
            // 
            // pnl_container
            // 
            this.pnl_container.Controls.Add(this.pnl_Control);
            this.pnl_container.Controls.Add(this.pnl_Content);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(2600, 1165);
            this.pnl_container.TabIndex = 4;
            // 
            // UCCnttBefore18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_container);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCCnttBefore18";
            this.Size = new System.Drawing.Size(2600, 1165);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Content)).EndInit();
            this.pnl_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaTextBox txt_Search;
        private Guna.UI.WinForms.GunaPanel pnl_Content;
        private Guna.UI.WinForms.GunaDataGridView dgv_Content;
        private Guna.UI.WinForms.GunaPanel pnl_container;
        private Guna.UI.WinForms.GunaButton btn_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numOfCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Semester;
    }
}
