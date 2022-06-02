
namespace Nsbm_University_Management_System
{
    partial class ScoreForm
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
            this.Search_Scr = new Guna.UI2.WinForms.Guna2TextBox();
            this.score_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.scr_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.clear_scr = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_scr = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Std_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Course_sele3 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.radio_score = new System.Windows.Forms.RadioButton();
            this.radio_students = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.score_table)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search_Scr
            // 
            this.Search_Scr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Scr.DefaultText = "";
            this.Search_Scr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Scr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Scr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Scr.DisabledState.Parent = this.Search_Scr;
            this.Search_Scr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Scr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Scr.FocusedState.Parent = this.Search_Scr;
            this.Search_Scr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Scr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Scr.HoverState.Parent = this.Search_Scr;
            this.Search_Scr.Location = new System.Drawing.Point(563, 8);
            this.Search_Scr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search_Scr.Name = "Search_Scr";
            this.Search_Scr.PasswordChar = '\0';
            this.Search_Scr.PlaceholderText = "Search";
            this.Search_Scr.SelectedText = "";
            this.Search_Scr.ShadowDecoration.Parent = this.Search_Scr;
            this.Search_Scr.Size = new System.Drawing.Size(375, 40);
            this.Search_Scr.TabIndex = 84;
            this.Search_Scr.TextChanged += new System.EventHandler(this.Search_scr_TextChanged);
            // 
            // score_table
            // 
            this.score_table.AllowUserToAddRows = false;
            this.score_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.score_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.score_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.score_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.score_table.ColumnHeadersHeight = 65;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.score_table.EnableHeadersVisualStyles = false;
            this.score_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table.Location = new System.Drawing.Point(0, 58);
            this.score_table.Name = "score_table";
            this.score_table.ReadOnly = true;
            this.score_table.RowHeadersVisible = false;
            this.score_table.RowHeadersWidth = 51;
            this.score_table.RowTemplate.Height = 65;
            this.score_table.RowTemplate.ReadOnly = true;
            this.score_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.score_table.Size = new System.Drawing.Size(1055, 394);
            this.score_table.TabIndex = 83;
            this.score_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.score_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.score_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.score_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.score_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.score_table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.score_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.score_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.score_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.score_table.ThemeStyle.HeaderStyle.Height = 65;
            this.score_table.ThemeStyle.ReadOnly = true;
            this.score_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.score_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.score_table.ThemeStyle.RowsStyle.Height = 65;
            this.score_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Plum;
            this.score_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.scr_desc);
            this.guna2Panel1.Controls.Add(this.clear_scr);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.score);
            this.guna2Panel1.Controls.Add(this.add_scr);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.Std_id);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.Course_sele3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 458);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 5;
            this.guna2Panel1.ShadowDecoration.Depth = 51;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1055, 280);
            this.guna2Panel1.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(543, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 104;
            this.label3.Text = "Description :";
            // 
            // scr_desc
            // 
            this.scr_desc.AllowDrop = true;
            this.scr_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scr_desc.DefaultText = "";
            this.scr_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.scr_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.scr_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scr_desc.DisabledState.Parent = this.scr_desc;
            this.scr_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scr_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scr_desc.FocusedState.Parent = this.scr_desc;
            this.scr_desc.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.scr_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scr_desc.HoverState.Parent = this.scr_desc;
            this.scr_desc.Location = new System.Drawing.Point(679, 51);
            this.scr_desc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scr_desc.Multiline = true;
            this.scr_desc.Name = "scr_desc";
            this.scr_desc.PasswordChar = '\0';
            this.scr_desc.PlaceholderText = "";
            this.scr_desc.SelectedText = "";
            this.scr_desc.ShadowDecoration.Parent = this.scr_desc;
            this.scr_desc.Size = new System.Drawing.Size(326, 111);
            this.scr_desc.TabIndex = 103;
            // 
            // clear_scr
            // 
            this.clear_scr.CheckedState.Parent = this.clear_scr;
            this.clear_scr.CustomImages.Parent = this.clear_scr;
            this.clear_scr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear_scr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear_scr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear_scr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear_scr.DisabledState.Parent = this.clear_scr;
            this.clear_scr.FillColor = System.Drawing.Color.DarkViolet;
            this.clear_scr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_scr.ForeColor = System.Drawing.Color.White;
            this.clear_scr.HoverState.Parent = this.clear_scr;
            this.clear_scr.Location = new System.Drawing.Point(695, 200);
            this.clear_scr.Name = "clear_scr";
            this.clear_scr.ShadowDecoration.Parent = this.clear_scr;
            this.clear_scr.Size = new System.Drawing.Size(145, 38);
            this.clear_scr.TabIndex = 102;
            this.clear_scr.Text = "Clear";
            this.clear_scr.Click += new System.EventHandler(this.clear_scr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(47, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 101;
            this.label1.Text = "Socre               :";
            // 
            // score
            // 
            this.score.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.score.DefaultText = "";
            this.score.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.score.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.score.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score.DisabledState.Parent = this.score;
            this.score.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score.FocusedState.Parent = this.score;
            this.score.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.score.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score.HoverState.Parent = this.score;
            this.score.Location = new System.Drawing.Point(215, 200);
            this.score.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.score.Name = "score";
            this.score.PasswordChar = '\0';
            this.score.PlaceholderText = "";
            this.score.SelectedText = "";
            this.score.ShadowDecoration.Parent = this.score;
            this.score.Size = new System.Drawing.Size(300, 38);
            this.score.TabIndex = 100;
            // 
            // add_scr
            // 
            this.add_scr.CheckedState.Parent = this.add_scr;
            this.add_scr.CustomImages.Parent = this.add_scr;
            this.add_scr.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_scr.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_scr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_scr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_scr.DisabledState.Parent = this.add_scr;
            this.add_scr.FillColor = System.Drawing.Color.DarkViolet;
            this.add_scr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_scr.ForeColor = System.Drawing.Color.White;
            this.add_scr.HoverState.Parent = this.add_scr;
            this.add_scr.Location = new System.Drawing.Point(860, 200);
            this.add_scr.Name = "add_scr";
            this.add_scr.ShadowDecoration.Parent = this.add_scr;
            this.add_scr.Size = new System.Drawing.Size(145, 38);
            this.add_scr.TabIndex = 95;
            this.add_scr.Text = "Add";
            this.add_scr.Click += new System.EventHandler(this.add_scr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkViolet;
            this.label5.Location = new System.Drawing.Point(46, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 23);
            this.label5.TabIndex = 99;
            this.label5.Text = "Student ID        :";
            // 
            // Std_id
            // 
            this.Std_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Std_id.DefaultText = "";
            this.Std_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Std_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Std_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Std_id.DisabledState.Parent = this.Std_id;
            this.Std_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Std_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Std_id.FocusedState.Parent = this.Std_id;
            this.Std_id.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Std_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Std_id.HoverState.Parent = this.Std_id;
            this.Std_id.Location = new System.Drawing.Point(215, 51);
            this.Std_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Std_id.Name = "Std_id";
            this.Std_id.PasswordChar = '\0';
            this.Std_id.PlaceholderText = "";
            this.Std_id.SelectedText = "";
            this.Std_id.ShadowDecoration.Parent = this.Std_id;
            this.Std_id.Size = new System.Drawing.Size(299, 38);
            this.Std_id.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(46, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 97;
            this.label4.Text = "Select Module :";
            // 
            // Course_sele3
            // 
            this.Course_sele3.BackColor = System.Drawing.Color.Transparent;
            this.Course_sele3.BorderRadius = 15;
            this.Course_sele3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Course_sele3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_sele3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Course_sele3.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Course_sele3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Course_sele3.FocusedState.Parent = this.Course_sele3;
            this.Course_sele3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_sele3.ForeColor = System.Drawing.Color.Gray;
            this.Course_sele3.FormattingEnabled = true;
            this.Course_sele3.HoverState.Parent = this.Course_sele3;
            this.Course_sele3.ItemHeight = 30;
            this.Course_sele3.ItemsAppearance.Parent = this.Course_sele3;
            this.Course_sele3.Location = new System.Drawing.Point(214, 126);
            this.Course_sele3.Name = "Course_sele3";
            this.Course_sele3.ShadowDecoration.Parent = this.Course_sele3;
            this.Course_sele3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.Course_sele3.Size = new System.Drawing.Size(300, 36);
            this.Course_sele3.TabIndex = 96;
            this.Course_sele3.Tag = "";
            this.Course_sele3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Search.TabIndex = 85;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // radio_score
            // 
            this.radio_score.AutoSize = true;
            this.radio_score.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_score.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_score.Location = new System.Drawing.Point(214, 13);
            this.radio_score.Name = "radio_score";
            this.radio_score.Size = new System.Drawing.Size(94, 27);
            this.radio_score.TabIndex = 87;
            this.radio_score.Text = "Scores";
            this.radio_score.UseVisualStyleBackColor = true;
            // 
            // radio_students
            // 
            this.radio_students.AutoSize = true;
            this.radio_students.Checked = true;
            this.radio_students.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_students.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_students.Location = new System.Drawing.Point(50, 13);
            this.radio_students.Name = "radio_students";
            this.radio_students.Size = new System.Drawing.Size(114, 27);
            this.radio_students.TabIndex = 86;
            this.radio_students.TabStop = true;
            this.radio_students.Text = "Students";
            this.radio_students.UseVisualStyleBackColor = true;
            this.radio_students.CheckedChanged += new System.EventHandler(this.radio_students_CheckedChanged);
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.radio_score);
            this.Controls.Add(this.radio_students);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_Scr);
            this.Controls.Add(this.score_table);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.Load += new System.EventHandler(this.ScoreForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.score_table)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Search;
        private Guna.UI2.WinForms.Guna2TextBox Search_Scr;
        private Guna.UI2.WinForms.Guna2DataGridView score_table;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox scr_desc;
        private Guna.UI2.WinForms.Guna2Button clear_scr;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox score;
        private Guna.UI2.WinForms.Guna2Button add_scr;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Std_id;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox Course_sele3;
        private System.Windows.Forms.RadioButton radio_score;
        private System.Windows.Forms.RadioButton radio_students;
    }
}