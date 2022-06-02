
namespace Nsbm_University_Management_System
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            this.Search_crs = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.hours = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_crs = new Guna.UI2.WinForms.Guna2Button();
            this.clear_crs = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.crs_desc = new Guna.UI2.WinForms.Guna2TextBox();
            this.crs_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.crs_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.crs_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Search = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crs_table)).BeginInit();
            this.SuspendLayout();
            // 
            // Search_crs
            // 
            this.Search_crs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_crs.DefaultText = "";
            this.Search_crs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_crs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_crs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_crs.DisabledState.Parent = this.Search_crs;
            this.Search_crs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_crs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_crs.FocusedState.Parent = this.Search_crs;
            this.Search_crs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_crs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_crs.HoverState.Parent = this.Search_crs;
            this.Search_crs.Location = new System.Drawing.Point(561, 8);
            this.Search_crs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Search_crs.Name = "Search_crs";
            this.Search_crs.PasswordChar = '\0';
            this.Search_crs.PlaceholderText = "Search";
            this.Search_crs.SelectedText = "";
            this.Search_crs.ShadowDecoration.Parent = this.Search_crs;
            this.Search_crs.Size = new System.Drawing.Size(375, 40);
            this.Search_crs.TabIndex = 80;
            this.Search_crs.TextChanged += new System.EventHandler(this.Search_crs_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.hours);
            this.guna2Panel1.Controls.Add(this.add_crs);
            this.guna2Panel1.Controls.Add(this.clear_crs);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.crs_desc);
            this.guna2Panel1.Controls.Add(this.crs_name);
            this.guna2Panel1.Controls.Add(this.crs_id);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 428);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 51;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Panel1.Size = new System.Drawing.Size(1055, 310);
            this.guna2Panel1.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(51, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hours            :";
            // 
            // hours
            // 
            this.hours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hours.DefaultText = "";
            this.hours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hours.DisabledState.Parent = this.hours;
            this.hours.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hours.FocusedState.Parent = this.hours;
            this.hours.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.hours.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.hours.HoverState.Parent = this.hours;
            this.hours.Location = new System.Drawing.Point(209, 230);
            this.hours.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hours.Name = "hours";
            this.hours.PasswordChar = '\0';
            this.hours.PlaceholderText = "";
            this.hours.SelectedText = "";
            this.hours.ShadowDecoration.Parent = this.hours;
            this.hours.Size = new System.Drawing.Size(291, 38);
            this.hours.TabIndex = 32;
            // 
            // add_crs
            // 
            this.add_crs.CheckedState.Parent = this.add_crs;
            this.add_crs.CustomImages.Parent = this.add_crs;
            this.add_crs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_crs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_crs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_crs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_crs.DisabledState.Parent = this.add_crs;
            this.add_crs.FillColor = System.Drawing.Color.DarkViolet;
            this.add_crs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_crs.ForeColor = System.Drawing.Color.White;
            this.add_crs.HoverState.Parent = this.add_crs;
            this.add_crs.Location = new System.Drawing.Point(847, 230);
            this.add_crs.Name = "add_crs";
            this.add_crs.ShadowDecoration.Parent = this.add_crs;
            this.add_crs.Size = new System.Drawing.Size(155, 38);
            this.add_crs.TabIndex = 31;
            this.add_crs.Text = "Add";
            this.add_crs.Click += new System.EventHandler(this.add_crs_Click);
            // 
            // clear_crs
            // 
            this.clear_crs.CheckedState.Parent = this.clear_crs;
            this.clear_crs.CustomImages.Parent = this.clear_crs;
            this.clear_crs.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clear_crs.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clear_crs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clear_crs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clear_crs.DisabledState.Parent = this.clear_crs;
            this.clear_crs.FillColor = System.Drawing.Color.DarkViolet;
            this.clear_crs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_crs.ForeColor = System.Drawing.Color.White;
            this.clear_crs.HoverState.Parent = this.clear_crs;
            this.clear_crs.Location = new System.Drawing.Point(671, 230);
            this.clear_crs.Name = "clear_crs";
            this.clear_crs.ShadowDecoration.Parent = this.clear_crs;
            this.clear_crs.Size = new System.Drawing.Size(155, 38);
            this.clear_crs.TabIndex = 30;
            this.clear_crs.Text = "Clear";
            this.clear_crs.Click += new System.EventHandler(this.clear_crs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Description     :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(547, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Course Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Course ID       :";
            // 
            // crs_desc
            // 
            this.crs_desc.AllowDrop = true;
            this.crs_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.crs_desc.DefaultText = "";
            this.crs_desc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.crs_desc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.crs_desc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_desc.DisabledState.Parent = this.crs_desc;
            this.crs_desc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_desc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_desc.FocusedState.Parent = this.crs_desc;
            this.crs_desc.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.crs_desc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_desc.HoverState.Parent = this.crs_desc;
            this.crs_desc.Location = new System.Drawing.Point(211, 122);
            this.crs_desc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crs_desc.Multiline = true;
            this.crs_desc.Name = "crs_desc";
            this.crs_desc.PasswordChar = '\0';
            this.crs_desc.PlaceholderText = "";
            this.crs_desc.SelectedText = "";
            this.crs_desc.ShadowDecoration.Parent = this.crs_desc;
            this.crs_desc.Size = new System.Drawing.Size(791, 76);
            this.crs_desc.TabIndex = 10;
            // 
            // crs_name
            // 
            this.crs_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.crs_name.DefaultText = "";
            this.crs_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.crs_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.crs_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_name.DisabledState.Parent = this.crs_name;
            this.crs_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_name.FocusedState.Parent = this.crs_name;
            this.crs_name.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.crs_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_name.HoverState.Parent = this.crs_name;
            this.crs_name.Location = new System.Drawing.Point(711, 52);
            this.crs_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crs_name.Name = "crs_name";
            this.crs_name.PasswordChar = '\0';
            this.crs_name.PlaceholderText = "";
            this.crs_name.SelectedText = "";
            this.crs_name.ShadowDecoration.Parent = this.crs_name;
            this.crs_name.Size = new System.Drawing.Size(291, 38);
            this.crs_name.TabIndex = 3;
            // 
            // crs_id
            // 
            this.crs_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.crs_id.DefaultText = "";
            this.crs_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.crs_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.crs_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_id.DisabledState.Parent = this.crs_id;
            this.crs_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.crs_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_id.FocusedState.Parent = this.crs_id;
            this.crs_id.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.crs_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.crs_id.HoverState.Parent = this.crs_id;
            this.crs_id.Location = new System.Drawing.Point(211, 52);
            this.crs_id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.crs_id.Name = "crs_id";
            this.crs_id.PasswordChar = '\0';
            this.crs_id.PlaceholderText = "";
            this.crs_id.SelectedText = "";
            this.crs_id.ShadowDecoration.Parent = this.crs_id;
            this.crs_id.Size = new System.Drawing.Size(291, 38);
            this.crs_id.TabIndex = 1;
            // 
            // crs_table
            // 
            this.crs_table.AllowUserToAddRows = false;
            this.crs_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.crs_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.crs_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.crs_table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.crs_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crs_table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.crs_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.crs_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.crs_table.ColumnHeadersHeight = 65;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crs_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.crs_table.EnableHeadersVisualStyles = false;
            this.crs_table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.crs_table.Location = new System.Drawing.Point(3, 58);
            this.crs_table.Name = "crs_table";
            this.crs_table.ReadOnly = true;
            this.crs_table.RowHeadersVisible = false;
            this.crs_table.RowHeadersWidth = 51;
            this.crs_table.RowTemplate.Height = 65;
            this.crs_table.RowTemplate.ReadOnly = true;
            this.crs_table.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.crs_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crs_table.Size = new System.Drawing.Size(1055, 364);
            this.crs_table.TabIndex = 82;
            this.crs_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.crs_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.crs_table.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.crs_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.crs_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.crs_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.crs_table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.crs_table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.crs_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkViolet;
            this.crs_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.crs_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.crs_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.crs_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.crs_table.ThemeStyle.HeaderStyle.Height = 65;
            this.crs_table.ThemeStyle.ReadOnly = true;
            this.crs_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.crs_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.crs_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.crs_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.crs_table.ThemeStyle.RowsStyle.Height = 65;
            this.crs_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Plum;
            this.crs_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
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
            this.Search.Location = new System.Drawing.Point(943, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(61, 40);
            this.Search.TabIndex = 81;
            this.Search.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Search.UseVisualStyleBackColor = false;
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1055, 738);
            this.Controls.Add(this.crs_table);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Search_crs);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseForm";
            this.Text = "CourseForm";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crs_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Search;
        private Guna.UI2.WinForms.Guna2TextBox Search_crs;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button add_crs;
        private Guna.UI2.WinForms.Guna2DataGridView crs_table;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox hours;
        private Guna.UI2.WinForms.Guna2Button clear_crs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox crs_desc;
        private Guna.UI2.WinForms.Guna2TextBox crs_name;
        private Guna.UI2.WinForms.Guna2TextBox crs_id;
    }
}