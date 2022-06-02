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
    public partial class ScoreForm : Form
    {
        
        Scores scr = new Scores();

        public ScoreForm()
        {
            InitializeComponent();
        }

        //=============================================== reusable ==============================================

        private void ShowScore()
        {
            score_table.DataSource = scr.GetScrInfo();
            if (!radio_score.Checked)
            {
                radio_score.Checked = true;
            }
        }

        public void ShowStd()
        {
            try
            {
                score_table.DataSource = scr.getSdt();
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchRslt(string keyword)
        {
            try
            {
                score_table.DataSource = scr.SearchScr(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModuleComboBox()
        {
            Course_sele3.DataSource = scr.GetCrsInfo();
            Course_sele3.DisplayMember = "CourseName";
            Course_sele3.ValueMember = "CourseName";
        }
        public void clearscr()
        {
            Std_id.Text="";
            score.Text="";
            Course_sele3.SelectedIndex = 0;
            scr_desc.Text="";
        }

        public void TableChngr()
        {
            if (radio_students.Checked)
            {
                ShowStd();
            }
            else
            {
                ShowScore();
            }
        }

        //=========================================================================================================================


        private void add_scr_Click(object sender, EventArgs e)
        {
            try
            {
                if (Std_id.Text == "" || score.Text == "")
                {
                    MessageBox.Show("Please fill all fields!", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    scr.Id = Convert.ToInt32(Std_id.Text);
                    scr.Cname = Course_sele3.Text;
                    scr.Scor = Convert.ToInt32(score.Text);
                    scr.Descr = scr_desc.Text;
                    if (!scr.checkScore())
                    {
                        if (scr.insertScore())
                        {
                            MessageBox.Show("New score added!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ShowScore();
                            clearscr();
                        }
                        else
                        {
                            MessageBox.Show("Score not added!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The score for this course are alerady exists!", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ScoreForm_Load_1(object sender, EventArgs e)
        {
            ShowStd();
            ModuleComboBox();
        }

        private void clear_scr_Click(object sender, EventArgs e)
        {
            clearscr();
        }

        private void radio_students_CheckedChanged(object sender, EventArgs e)
        {
            TableChngr();
        }

        private void Search_scr_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_Scr.Text);
        }
    }
}
