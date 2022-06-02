
namespace Nsbm_University_Management_System
{
    partial class PrintStudentForm
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.radio_all = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_female3 = new System.Windows.Forms.RadioButton();
            this.radio_male3 = new System.Windows.Forms.RadioButton();
            this.print = new Guna.UI2.WinForms.Guna2Button();
            this.Search3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.std_table_print = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.std_table_print)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.radio_all);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.radio_female3);
            this.guna2Panel1.Controls.Add(this.radio_male3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 538);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 5;
            this.guna2Panel1.ShadowDecoration.Depth = 51;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1055, 200);
            this.guna2Panel1.TabIndex = 77;
            // 
            // radio_all
            // 
            this.radio_all.AutoSize = true;
            this.radio_all.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_all.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_all.Location = new System.Drawing.Point(410, 119);
            this.radio_all.Name = "radio_all";
            this.radio_all.Size = new System.Drawing.Size(56, 27);
            this.radio_all.TabIndex = 84;
            this.radio_all.TabStop = true;
            this.radio_all.Text = "All";
            this.radio_all.UseVisualStyleBackColor = true;
            this.radio_all.CheckedChanged += new System.EventHandler(this.radio_all_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(46, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Select Module :";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 15;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Gray;
            this.guna2ComboBox1.FormattingEnabled = true;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Total Students",
            "Software Architecture"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(214, 62);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.guna2ComboBox1.Size = new System.Drawing.Size(250, 36);
            this.guna2ComboBox1.TabIndex = 82;
            this.guna2ComboBox1.Tag = "";
            this.guna2ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkViolet;
            this.label6.Location = new System.Drawing.Point(46, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Gender            :";
            // 
            // radio_female3
            // 
            this.radio_female3.AutoSize = true;
            this.radio_female3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_female3.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_female3.Location = new System.Drawing.Point(300, 119);
            this.radio_female3.Name = "radio_female3";
            this.radio_female3.Size = new System.Drawing.Size(104, 27);
            this.radio_female3.TabIndex = 33;
            this.radio_female3.TabStop = true;
            this.radio_female3.Text = "Female";
            this.radio_female3.UseVisualStyleBackColor = true;
            this.radio_female3.CheckedChanged += new System.EventHandler(this.radio_female3_CheckedChanged);
            // 
            // radio_male3
            // 
            this.radio_male3.AutoSize = true;
            this.radio_male3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_male3.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_male3.Location = new System.Drawing.Point(214, 119);
            this.radio_male3.Name = "radio_male3";
            this.radio_male3.Size = new System.Drawing.Size(80, 27);
            this.radio_male3.TabIndex = 32;
            this.radio_male3.TabStop = true;
            this.radio_male3.Text = "Male";
            this.radio_male3.UseVisualStyleBackColor = true;
            this.radio_male3.CheckedChanged += new System.EventHandler(this.radio_male3_CheckedChanged);
            // 
            // print
            // 
            this.print.CheckedState.Parent = this.print;
            this.print.CustomImages.Parent = this.print;
            this.print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.print.DisabledState.Parent = this.print;
            this.print.FillColor = System.Drawing.Color.DarkViolet;
            this.print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.HoverState.Parent = this.print;
            this.print.Location = new System.Drawing.Point(875, 642);
            this.print.Name = "print";
            this.print.ShadowDecoration.Parent = this.print;
            this.print.Size = new System.Drawing.Size(130, 42);
            this.print.TabIndex = 35;
            this.print.Text = "Print";
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Search3
            // 
            this.Search3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search3.DefaultText = "";
            this.Search3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search3.DisabledState.Parent = this.Search3;
            this.Search3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search3.FocusedState.Parent = this.Search3;
            this.Search3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search3.HoverState.Parent = this.Search3;
            this.Search3.Location = new System.Drawing.Point(564, 8);
            this.Search3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search3.Name = "Search3";
            this.Search3.PasswordChar = '\0';
            this.Search3.PlaceholderText = "Search";
            this.Search3.SelectedText = "";
            this.Search3.ShadowDecoration.Parent = this.Search3;
            this.Search3.Size = new System.Drawing.Size(375, 40);
            this.Search3.TabIndex = 79;
            this.Search3.TextChanged += new System.EventHandler(this.Search3_TextChanged);
            // 
            // std_table_print
            // 
            this.std_table_print.AllowUserToAddRows = false;
            this.std_table_print.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.std_table_print.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.std_table_print.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.std_table_print.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.std_table_print.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.std_table_print.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.std_table_print.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.std_table_print.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.std_table_print.ColumnHeadersHeight = 65;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.std_table_print.DefaultCellStyle = dataGridViewCellStyle3;
            this.std_table_print.EnableHeadersVisualStyles = false;
            this.std_table_print.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.std_table_print.Location = new System.Drawing.Point(0, 58);
            this.std_table_print.Name = "std_table_print";
            this.std_table_print.ReadOnly = true;
            this.std_table_print.RowHeadersVisible = false;
            this.std_table_print.RowHeadersWidth = 51;
            this.std_table_print.RowTemplate.Height = 65;
            this.std_table_print.RowTemplate.ReadOnly = true;
            this.std_table_print.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.std_table_print.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.std_table_print.Size = new System.Drawing.Size(1055, 474);
            this.std_table_print.TabIndex = 78;
            this.std_table_print.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.std_table_print.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.std_table_print.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.std_table_print.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.std_table_print.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.std_table_print.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.std_table_print.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.std_table_print.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.std_table_print.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.std_table_print.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.std_table_print.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.std_table_print.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.std_table_print.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.std_table_print.ThemeStyle.HeaderStyle.Height = 65;
            this.std_table_print.ThemeStyle.ReadOnly = true;
            this.std_table_print.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.std_table_print.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.std_table_print.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.std_table_print.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.std_table_print.ThemeStyle.RowsStyle.Height = 65;
            this.std_table_print.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Plum;
            this.std_table_print.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.Search.Location = new System.Drawing.Point(946, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 40);
            this.Search.TabIndex = 80;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search3);
            this.Controls.Add(this.std_table_print);
            this.Controls.Add(this.print);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintStudentForm";
            this.Text = "PrintStudentForm";
            this.Load += new System.EventHandler(this.PrintStudentForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.std_table_print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button print;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radio_female3;
        private System.Windows.Forms.RadioButton radio_male3;
        private FontAwesome.Sharp.IconButton Search;
        private Guna.UI2.WinForms.Guna2TextBox Search3;
        private Guna.UI2.WinForms.Guna2DataGridView std_table_print;
        private System.Windows.Forms.RadioButton radio_all;
    }
}