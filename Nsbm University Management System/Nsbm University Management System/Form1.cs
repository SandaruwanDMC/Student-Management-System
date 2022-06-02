using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsbm_University_Management_System
{
    public partial class Form1 : Form
    {
        Students std = new Students();
        User user = new User();
       
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            studentCount();
            ModuleComboBox();

        }
        //======================================================================= Reuseable =====================================================================
        private void studentCount()
        {
            try
            {
                total.Text = std.totalStudent(crs_combo.Text);
                male.Text = std.maleStudent(crs_combo.Text);
                female.Text = std.femaleStudent(crs_combo.Text);
            }catch(Exception e)
            {
                 MessageBox.Show(e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void customizeDesign()
        {
            panel_stdsubmenu.Visible = false;
            panel_courseSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;

        }

        private void hideSubmenu()
        {
            if (panel_stdsubmenu.Visible == true)
                panel_stdsubmenu.Visible = false;
            if (panel_courseSubmenu.Visible == true)
                panel_courseSubmenu.Visible = false;
            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public void ModuleComboBox()
        {
            Scores scr = new Scores();
            crs_combo.DataSource = scr.GetCrsInfo();
            crs_combo.DisplayMember = "CourseName";
            crs_combo.ValueMember = "CourseName";
        }

        //=================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            openChildForm(new RegisterForm());
            Sub_Name.Text = "Student Registration";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            hideSubmenu();
        }

        private void button_manageStd_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudentForm());
            Sub_Name.Text = "Manage Student";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {

            openChildForm(new PrintStudentForm());
            Sub_Name.Text = "Print Student";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            hideSubmenu();
        }
        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_courseSubmenu);
        }

        private void button_newCourse_Click(object sender, EventArgs e)
        {
            openChildForm(new CourseForm());
            Sub_Name.Text = "New Course";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Book;
            hideSubmenu();
        }

        private void button_manageCourse_Click(object sender, EventArgs e)
        {

            openChildForm(new ManageCourse());
            Sub_Name.Text = "Manage Course";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Book;
            hideSubmenu();
        }

        private void button_coursePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintCourseForm());
            Sub_Name.Text = "Print Coruse";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Book;
            hideSubmenu();
        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        private void button_newScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreForm());
            Sub_Name.Text = "New Score";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Medal;
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            openChildForm(new ScoreManageForm());
            Sub_Name.Text = "Manage Score";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Medal;
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            openChildForm(new PrintScoreForm());
            Sub_Name.Text = "Print Score";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Medal;
            hideSubmenu();
        }
        private void blogs_Click(object sender, EventArgs e)
        {

            openChildForm(new BlogsForm());
            Sub_Name.Text = "Blog";
            sub_icon.IconChar = FontAwesome.Sharp.IconChar.Blog;
            hideSubmenu();
        }
        private void iconButton1_MouseHover(object sender, EventArgs e)
        {
            iconButton1.ForeColor = Color.DarkViolet;
            iconButton1.IconColor = Color.DarkViolet;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e)
        {
            iconButton1.ForeColor = Color.Gray;
            iconButton1.IconColor = Color.Gray;
        }

        private void button_std_MouseHover(object sender, EventArgs e)
        {
                 button_std.ForeColor = Color.DarkViolet;
                 button_std.IconColor = Color.DarkViolet;
        }

        private void button_std_MouseLeave(object sender, EventArgs e)
        {
            button_std.ForeColor = Color.Gray;
            button_std.IconColor = Color.Gray;
        }

        private void button_course_MouseHover(object sender, EventArgs e)
        {
            button_course.ForeColor = Color.DarkViolet;
            button_course.IconColor = Color.DarkViolet;
        }

        private void button_course_MouseLeave(object sender, EventArgs e)
        {
            button_course.ForeColor = Color.Gray;
            button_course.IconColor = Color.Gray;

        }

        private void button_score_MouseHover(object sender, EventArgs e)
        {
            button_score.ForeColor = Color.DarkViolet;
            button_score.IconColor = Color.DarkViolet;
        }

        private void button_score_MouseLeave(object sender, EventArgs e)
        {
            button_score.ForeColor = Color.Gray;
            button_score.IconColor = Color.Gray;

        }

        private void iconButton15_MouseHover(object sender, EventArgs e)
        {

            blogs.ForeColor = Color.DarkViolet;
            blogs.IconColor = Color.DarkViolet;
        }

        private void iconButton15_MouseLeave(object sender, EventArgs e)
        {
            blogs.ForeColor = Color.Gray;
            blogs.IconColor = Color.Gray;
        }

       

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
              
                Sub_Name.Text = "Dashboard";
                sub_icon.IconChar = FontAwesome.Sharp.IconChar.Home;
                studentCount();
                ModuleComboBox();
                if (activeForm != null)
                    activeForm.Close();
                panel_main.Controls.Add(panel_main2);
                //studentCount();
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentCount();
        }

        private void signout_Click(object sender, EventArgs e)
        {
            user.Uname = "";
            user.Passwrd = "";
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
