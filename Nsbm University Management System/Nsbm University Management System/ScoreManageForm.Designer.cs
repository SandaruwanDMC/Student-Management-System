
namespace Nsbm_University_Management_System
{
    partial class ScoreManageForm
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
            this.radio_score2 = new System.Windows.Forms.RadioButton();
            this.radio_students2 = new System.Windows.Forms.RadioButton();
            this.Search_scr2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.score_table2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.scr_del = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.scr_desc2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.clear_scr3 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.score2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.scr_update = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Std_id2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Course_sele4 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Search = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.score_table2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_score2
            // 
            this.radio_score2.AutoSize = true;
            this.radio_score2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_score2.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_score2.Location = new System.Drawing.Point(214, 13);
            this.radio_score2.Name = "radio_score2";
            this.radio_score2.Size = new System.Drawing.Size(94, 27);
            this.radio_score2.TabIndex = 93;
            this.radio_score2.Text = "Scores";
            this.radio_score2.UseVisualStyleBackColor = true;
            // 
            // radio_students2
            // 
            this.radio_students2.AutoSize = true;
            this.radio_students2.Checked = true;
            this.radio_students2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_students2.ForeColor = System.Drawing.Color.DarkViolet;
            this.radio_students2.Location = new System.Drawing.Point(50, 13);
            this.radio_students2.Name = "radio_students2";
            this.radio_students2.Size = new System.Drawing.Size(114, 27);
            this.radio_students2.TabIndex = 92;
            this.radio_students2.TabStop = true;
            this.radio_students2.Text = "Students";
            this.radio_students2.UseVisualStyleBackColor = true;
            this.radio_students2.CheckedChanged += new System.EventHandler(this.radio_students2_CheckedChanged);
            // 
            // Search_scr2
            // 
            this.Search_scr2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_scr2.DefaultText = "";
            this.Search_scr2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_scr2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_scr2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_scr2.DisabledState.Parent = this.Search_scr2;
            this.Search_scr2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_scr2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_scr2.FocusedState.Parent = this.Search_scr2;
            this.Search_scr2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_scr2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_scr2.HoverState.Parent = this.Search_scr2;
            this.Search_scr2.Location = new System.Drawing.Point(563, 8);
            this.Search_scr2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search_scr2.Name = "Search_scr2";
            this.Search_scr2.PasswordChar = '\0';
            this.Search_scr2.PlaceholderText = "Search";
            this.Search_scr2.SelectedText = "";
            this.Search_scr2.ShadowDecoration.Parent = this.Search_scr2;
            this.Search_scr2.Size = new System.Drawing.Size(375, 40);
            this.Search_scr2.TabIndex = 90;
            this.Search_scr2.TextChanged += new System.EventHandler(this.Search_scr2_TextChanged);
            // 
            // score_table2
            // 
            this.score_table2.AllowUserToAddRows = false;
            this.score_table2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.score_table2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.score_table2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.score_table2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.score_table2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.score_table2.ColumnHeadersHeight = 65;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table2.DefaultCellStyle = dataGridViewCellStyle3;
            this.score_table2.EnableHeadersVisualStyles = false;
            this.score_table2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table2.Location = new System.Drawing.Point(0, 58);
            this.score_table2.Name = "score_table2";
            this.score_table2.ReadOnly = true;
            this.score_table2.RowHeadersVisible = false;
            this.score_table2.RowHeadersWidth = 51;
            this.score_table2.RowTemplate.Height = 65;
            this.score_table2.RowTemplate.ReadOnly = true;
            this.score_table2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.score_table2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.score_table2.Size = new System.Drawing.Size(1055, 394);
            this.score_table2.TabIndex = 89;
            this.score_table2.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.score_table2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.score_table2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.score_table2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.score_table2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.score_table2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.score_table2.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.score_table2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.score_table2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.score_table2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.score_table2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.score_table2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.score_table2.ThemeStyle.HeaderStyle.Height = 65;
            this.score_table2.ThemeStyle.ReadOnly = true;
            this.score_table2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.score_table2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.score_table2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.score_table2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.score_table2.ThemeStyle.RowsStyle.Height = 65;
            this.score_table2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Plum;
            this.score_table2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.score_table2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.score_table2_CellClick);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.scr_del);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.scr_desc2);
            this.guna2Panel1.Controls.Add(this.clear_scr3);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.score2);
            this.guna2Panel1.Controls.Add(this.scr_update);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.Std_id2);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.Course_sele4);
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
            this.guna2Panel1.TabIndex = 88;
            // 
            // scr_del
            // 
            this.scr_del.CheckedState.Parent = this.scr_del;
            this.scr_del.CustomImages.Parent = this.scr_del;
            this.scr_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.scr_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.scr_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scr_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.scr_del.DisabledState.Parent = this.scr_del;
            this.scr_del.FillColor = System.Drawing.Color.DarkViolet;
            this.scr_del.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_del.ForeColor = System.Drawing.Color.White;
            this.scr_del.HoverState.Parent = this.scr_del;
            this.scr_del.Location = new System.Drawing.Point(859, 200);
            this.scr_del.Name = "scr_del";
            this.scr_del.ShadowDecoration.Parent = this.scr_del;
            this.scr_del.Size = new System.Drawing.Size(145, 38);
            this.scr_del.TabIndex = 105;
            this.scr_del.Text = "Delete";
            this.scr_del.Click += new System.EventHandler(this.scr_del_Click);
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
            // scr_desc2
            // 
            this.scr_desc2.AllowDrop = true;
            this.scr_desc2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.scr_desc2.DefaultText = "";
            this.scr_desc2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.scr_desc2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.scr_desc2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scr_desc2.DisabledState.Parent = this.scr_desc2;
            this.scr_desc2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.scr_desc2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scr_desc2.FocusedState.Parent = this.scr_desc2;
            this.scr_desc2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.scr_desc2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.scr_desc2.HoverState.Parent = this.scr_desc2;
            this.scr_desc2.Location = new System.Drawing.Point(679, 51);
            this.scr_desc2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scr_desc2.Multiline = true;
            this.scr_desc2.Name = "scr_desc2";
            this.scr_desc2.PasswordChar = '\0';
            this.scr_desc2.PlaceholderText = "";
            this.scr_desc2.SelectedText = "";
            this.scr_desc2.ShadowDecoration.Parent = this.scr_desc2;
            this.scr_desc2.Size = new System.Drawing.Size(326, 111);
            this.scr_desc2.TabIndex = 103;
            // 
            // clear_scr3
            // 
            this.clear_scr3.CheckedState.Parent = this.clear_scr3;
            this.clear_scr3.CustomImages.Parent = this.clear_scr3;
            this.clear_scr3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear_scr3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear_scr3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear_scr3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear_scr3.DisabledState.Parent = this.clear_scr3;
            this.clear_scr3.FillColor = System.Drawing.Color.DarkViolet;
            this.clear_scr3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_scr3.ForeColor = System.Drawing.Color.White;
            this.clear_scr3.HoverState.Parent = this.clear_scr3;
            this.clear_scr3.Location = new System.Drawing.Point(547, 200);
            this.clear_scr3.Name = "clear_scr3";
            this.clear_scr3.ShadowDecoration.Parent = this.clear_scr3;
            this.clear_scr3.Size = new System.Drawing.Size(145, 38);
            this.clear_scr3.TabIndex = 102;
            this.clear_scr3.Text = "Clear";
            this.clear_scr3.Click += new System.EventHandler(this.clear_scr3_Click);
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
            // score2
            // 
            this.score2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.score2.DefaultText = "";
            this.score2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.score2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.score2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score2.DisabledState.Parent = this.score2;
            this.score2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.score2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score2.FocusedState.Parent = this.score2;
            this.score2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.score2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.score2.HoverState.Parent = this.score2;
            this.score2.Location = new System.Drawing.Point(215, 200);
            this.score2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.score2.Name = "score2";
            this.score2.PasswordChar = '\0';
            this.score2.PlaceholderText = "";
            this.score2.SelectedText = "";
            this.score2.ShadowDecoration.Parent = this.score2;
            this.score2.Size = new System.Drawing.Size(300, 38);
            this.score2.TabIndex = 100;
            // 
            // scr_update
            // 
            this.scr_update.CheckedState.Parent = this.scr_update;
            this.scr_update.CustomImages.Parent = this.scr_update;
            this.scr_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.scr_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.scr_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.scr_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.scr_update.DisabledState.Parent = this.scr_update;
            this.scr_update.FillColor = System.Drawing.Color.DarkViolet;
            this.scr_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scr_update.ForeColor = System.Drawing.Color.White;
            this.scr_update.HoverState.Parent = this.scr_update;
            this.scr_update.Location = new System.Drawing.Point(703, 200);
            this.scr_update.Name = "scr_update";
            this.scr_update.ShadowDecoration.Parent = this.scr_update;
            this.scr_update.Size = new System.Drawing.Size(145, 38);
            this.scr_update.TabIndex = 95;
            this.scr_update.Text = "Update";
            this.scr_update.Click += new System.EventHandler(this.scr_update_Click);
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
            // Std_id2
            // 
            this.Std_id2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Std_id2.DefaultText = "";
            this.Std_id2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Std_id2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Std_id2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Std_id2.DisabledState.Parent = this.Std_id2;
            this.Std_id2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Std_id2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Std_id2.FocusedState.Parent = this.Std_id2;
            this.Std_id2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Std_id2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Std_id2.HoverState.Parent = this.Std_id2;
            this.Std_id2.Location = new System.Drawing.Point(215, 51);
            this.Std_id2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Std_id2.Name = "Std_id2";
            this.Std_id2.PasswordChar = '\0';
            this.Std_id2.PlaceholderText = "";
            this.Std_id2.ReadOnly = true;
            this.Std_id2.SelectedText = "";
            this.Std_id2.ShadowDecoration.Parent = this.Std_id2;
            this.Std_id2.Size = new System.Drawing.Size(299, 38);
            this.Std_id2.TabIndex = 98;
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
            // Course_sele4
            // 
            this.Course_sele4.BackColor = System.Drawing.Color.Transparent;
            this.Course_sele4.BorderRadius = 15;
            this.Course_sele4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Course_sele4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course_sele4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Course_sele4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Course_sele4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Course_sele4.FocusedState.Parent = this.Course_sele4;
            this.Course_sele4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Course_sele4.ForeColor = System.Drawing.Color.Gray;
            this.Course_sele4.FormattingEnabled = true;
            this.Course_sele4.HoverState.Parent = this.Course_sele4;
            this.Course_sele4.ItemHeight = 30;
            this.Course_sele4.ItemsAppearance.Parent = this.Course_sele4;
            this.Course_sele4.Location = new System.Drawing.Point(214, 126);
            this.Course_sele4.Name = "Course_sele4";
            this.Course_sele4.ShadowDecoration.Parent = this.Course_sele4;
            this.Course_sele4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3);
            this.Course_sele4.Size = new System.Drawing.Size(300, 36);
            this.Course_sele4.TabIndex = 96;
            this.Course_sele4.Tag = "";
            this.Course_sele4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // ScoreManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.radio_score2);
            this.Controls.Add(this.radio_students2);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_scr2);
            this.Controls.Add(this.score_table2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScoreManageForm";
            this.Text = "ScoreManageForm";
            this.Load += new System.EventHandler(this.ScoreManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.score_table2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_score2;
        private System.Windows.Forms.RadioButton radio_students2;
        private FontAwesome.Sharp.IconButton Search;
        private Guna.UI2.WinForms.Guna2TextBox Search_scr2;
        private Guna.UI2.WinForms.Guna2DataGridView score_table2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox scr_desc2;
        private Guna.UI2.WinForms.Guna2Button clear_scr3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox score2;
        private Guna.UI2.WinForms.Guna2Button scr_update;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox Std_id2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox Course_sele4;
        private Guna.UI2.WinForms.Guna2Button scr_del;
    }
}