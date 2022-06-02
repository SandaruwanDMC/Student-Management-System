
namespace Nsbm_University_Management_System
{
    partial class PrintScoreForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.radio_score3 = new System.Windows.Forms.RadioButton();
            this.radio_students3 = new System.Windows.Forms.RadioButton();
            this.Search_scr3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.score_table_print = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.scr_print = new Guna.UI2.WinForms.Guna2Button();
            this.Search = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.score_table_print)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_score3
            // 
            this.radio_score3.AutoSize = true;
            this.radio_score3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_score3.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_score3.Location = new System.Drawing.Point(214, 13);
            this.radio_score3.Name = "radio_score3";
            this.radio_score3.Size = new System.Drawing.Size(94, 27);
            this.radio_score3.TabIndex = 93;
            this.radio_score3.Text = "Scores";
            this.radio_score3.UseVisualStyleBackColor = true;
            // 
            // radio_students3
            // 
            this.radio_students3.AutoSize = true;
            this.radio_students3.Checked = true;
            this.radio_students3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_students3.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_students3.Location = new System.Drawing.Point(50, 13);
            this.radio_students3.Name = "radio_students3";
            this.radio_students3.Size = new System.Drawing.Size(114, 27);
            this.radio_students3.TabIndex = 92;
            this.radio_students3.TabStop = true;
            this.radio_students3.Text = "Students";
            this.radio_students3.UseVisualStyleBackColor = true;
            this.radio_students3.CheckedChanged += new System.EventHandler(this.radio_students3_CheckedChanged);
            // 
            // Search_scr3
            // 
            this.Search_scr3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_scr3.DefaultText = "";
            this.Search_scr3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_scr3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_scr3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_scr3.DisabledState.Parent = this.Search_scr3;
            this.Search_scr3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_scr3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_scr3.FocusedState.Parent = this.Search_scr3;
            this.Search_scr3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_scr3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_scr3.HoverState.Parent = this.Search_scr3;
            this.Search_scr3.Location = new System.Drawing.Point(563, 8);
            this.Search_scr3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search_scr3.Name = "Search_scr3";
            this.Search_scr3.PasswordChar = '\0';
            this.Search_scr3.PlaceholderText = "Search";
            this.Search_scr3.SelectedText = "";
            this.Search_scr3.ShadowDecoration.Parent = this.Search_scr3;
            this.Search_scr3.Size = new System.Drawing.Size(375, 40);
            this.Search_scr3.TabIndex = 90;
            this.Search_scr3.TextChanged += new System.EventHandler(this.Search_scr3_TextChanged);
            // 
            // score_table_print
            // 
            this.score_table_print.AllowUserToAddRows = false;
            this.score_table_print.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table_print.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.score_table_print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.score_table_print.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table_print.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_table_print.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table_print.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.score_table_print.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.score_table_print.ColumnHeadersHeight = 65;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table_print.DefaultCellStyle = dataGridViewCellStyle3;
            this.score_table_print.EnableHeadersVisualStyles = false;
            this.score_table_print.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table_print.Location = new System.Drawing.Point(0, 58);
            this.score_table_print.Name = "score_table_print";
            this.score_table_print.ReadOnly = true;
            this.score_table_print.RowHeadersVisible = false;
            this.score_table_print.RowHeadersWidth = 51;
            this.score_table_print.RowTemplate.Height = 65;
            this.score_table_print.RowTemplate.ReadOnly = true;
            this.score_table_print.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table_print.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.score_table_print.Size = new System.Drawing.Size(1055, 524);
            this.score_table_print.TabIndex = 89;
            this.score_table_print.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.score_table_print.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table_print.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.score_table_print.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.score_table_print.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.score_table_print.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.score_table_print.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table_print.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table_print.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.score_table_print.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.score_table_print.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table_print.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.score_table_print.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.score_table_print.ThemeStyle.HeaderStyle.Height = 65;
            this.score_table_print.ThemeStyle.ReadOnly = true;
            this.score_table_print.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.score_table_print.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table_print.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table_print.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.score_table_print.ThemeStyle.RowsStyle.Height = 65;
            this.score_table_print.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Plum;
            this.score_table_print.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.scr_print);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 588);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 5;
            this.guna2Panel1.ShadowDecoration.Depth = 51;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1055, 150);
            this.guna2Panel1.TabIndex = 88;
            // 
            // scr_print
            // 
            this.scr_print.CheckedState.Parent = this.scr_print;
            this.scr_print.CustomImages.Parent = this.scr_print;
            this.scr_print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.scr_print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.scr_print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scr_print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.scr_print.DisabledState.Parent = this.scr_print;
            this.scr_print.FillColor = System.Drawing.Color.DarkViolet;
            this.scr_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_print.ForeColor = System.Drawing.Color.White;
            this.scr_print.HoverState.Parent = this.scr_print;
            this.scr_print.Location = new System.Drawing.Point(854, 55);
            this.scr_print.Name = "scr_print";
            this.scr_print.ShadowDecoration.Parent = this.scr_print;
            this.scr_print.Size = new System.Drawing.Size(150, 43);
            this.scr_print.TabIndex = 95;
            this.scr_print.Text = "Print";
            this.scr_print.Click += new System.EventHandler(this.scr_print_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkViolet;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.ForeColor = System.Drawing.Color.Silver;
            this.Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Search.IconColor = System.Drawing.Color.White;
            this.Search.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Search.IconSize = 25;
            this.Search.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Search.Location = new System.Drawing.Point(945, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 40);
            this.Search.TabIndex = 91;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.radio_score3);
            this.Controls.Add(this.radio_students3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_scr3);
            this.Controls.Add(this.score_table_print);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintScoreForm";
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_table_print)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_score3;
        private System.Windows.Forms.RadioButton radio_students3;
        private FontAwesome.Sharp.IconButton Search;
        private Guna.UI2.WinForms.Guna2TextBox Search_scr3;
        private Guna.UI2.WinForms.Guna2DataGridView score_table_print;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button scr_print;
    }
}