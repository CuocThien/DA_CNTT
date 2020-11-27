namespace DA_CNTT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Control = new Guna.UI.WinForms.GunaPanel();
            this.txt_Search = new Guna.UI.WinForms.GunaTextBox();
            this.cb_Search = new Guna.UI.WinForms.GunaComboBox();
            this.pnl_Content = new Guna.UI.WinForms.GunaPanel();
            this.dgv_Content = new Guna.UI.WinForms.GunaDataGridView();
            this.col_SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Catogories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_numOfCredits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Control.SuspendLayout();
            this.pnl_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Content)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Control
            // 
            this.pnl_Control.Controls.Add(this.cb_Search);
            this.pnl_Control.Controls.Add(this.txt_Search);
            this.pnl_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Control.Location = new System.Drawing.Point(0, 0);
            this.pnl_Control.Name = "pnl_Control";
            this.pnl_Control.Size = new System.Drawing.Size(2374, 112);
            this.pnl_Control.TabIndex = 0;
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
            this.txt_Search.Location = new System.Drawing.Point(483, 14);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.Radius = 15;
            this.txt_Search.Size = new System.Drawing.Size(1287, 83);
            this.txt_Search.TabIndex = 0;
            // 
            // cb_Search
            // 
            this.cb_Search.BackColor = System.Drawing.Color.Transparent;
            this.cb_Search.BaseColor = System.Drawing.Color.White;
            this.cb_Search.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_Search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Search.FocusedColor = System.Drawing.Color.Empty;
            this.cb_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Search.ForeColor = System.Drawing.Color.Red;
            this.cb_Search.FormattingEnabled = true;
            this.cb_Search.Items.AddRange(new object[] {
            "MÃ MÔN HỌC",
            "TÊN MÔN HỌC"});
            this.cb_Search.Location = new System.Drawing.Point(1370, 30);
            this.cb_Search.Name = "cb_Search";
            this.cb_Search.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Search.OnHoverItemForeColor = System.Drawing.Color.Red;
            this.cb_Search.Radius = 10;
            this.cb_Search.Size = new System.Drawing.Size(385, 51);
            this.cb_Search.TabIndex = 1;
            // 
            // pnl_Content
            // 
            this.pnl_Content.Controls.Add(this.dgv_Content);
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Content.Location = new System.Drawing.Point(0, 112);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(2374, 887);
            this.pnl_Content.TabIndex = 1;
            // 
            // dgv_Content
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgv_Content.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Content.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Content.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Content.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Content.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Content.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Content.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Content.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_SubjectID,
            this.col_SubjectName,
            this.col_Catogories,
            this.col_numOfCredits});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Content.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Content.EnableHeadersVisualStyles = false;
            this.dgv_Content.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Content.Location = new System.Drawing.Point(0, 0);
            this.dgv_Content.Name = "dgv_Content";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Content.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Content.RowHeadersVisible = false;
            this.dgv_Content.RowHeadersWidth = 82;
            this.dgv_Content.RowTemplate.Height = 33;
            this.dgv_Content.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Content.Size = new System.Drawing.Size(2374, 887);
            this.dgv_Content.TabIndex = 0;
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
            this.dgv_Content.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Content.ThemeStyle.HeaderStyle.Height = 42;
            this.dgv_Content.ThemeStyle.ReadOnly = false;
            this.dgv_Content.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Content.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Content.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_Content.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Content.ThemeStyle.RowsStyle.Height = 33;
            this.dgv_Content.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Content.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // col_SubjectID
            // 
            this.col_SubjectID.HeaderText = "Mã môn học";
            this.col_SubjectID.MinimumWidth = 10;
            this.col_SubjectID.Name = "col_SubjectID";
            // 
            // col_SubjectName
            // 
            this.col_SubjectName.HeaderText = "Tên môn học";
            this.col_SubjectName.MinimumWidth = 10;
            this.col_SubjectName.Name = "col_SubjectName";
            // 
            // col_Catogories
            // 
            this.col_Catogories.HeaderText = "Loại môn học";
            this.col_Catogories.MinimumWidth = 10;
            this.col_Catogories.Name = "col_Catogories";
            // 
            // col_numOfCredits
            // 
            this.col_numOfCredits.HeaderText = "Số tín chỉ";
            this.col_numOfCredits.MinimumWidth = 10;
            this.col_numOfCredits.Name = "col_numOfCredits";
            // 
            // UCCnttBefore18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.pnl_Control);
            this.Name = "UCCnttBefore18";
            this.Size = new System.Drawing.Size(2374, 999);
            this.pnl_Control.ResumeLayout(false);
            this.pnl_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Content)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnl_Control;
        private Guna.UI.WinForms.GunaTextBox txt_Search;
        private Guna.UI.WinForms.GunaComboBox cb_Search;
        private Guna.UI.WinForms.GunaPanel pnl_Content;
        private Guna.UI.WinForms.GunaDataGridView dgv_Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Catogories;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_numOfCredits;
    }
}
