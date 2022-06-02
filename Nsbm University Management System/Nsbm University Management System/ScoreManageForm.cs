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
    public partial class ScoreManageForm : Form
    {
        Scores scr = new Scores();
        bool Locked = false;

        public ScoreManageForm()
        {
            InitializeComponent();
        }

        //=============================================== reusable ==============================================

        private void ShowScore()
        {
            score_table2.DataSource = scr.GetScrInfo();
            if (!radio_score2.Checked)
            {
                radio_score2.Checked = true;
            }
        }

        public void ShowStd()
        {
            try
            {
                score_table2.DataSource = scr.getSdt();
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ModuleComboBox()
        {
            Course_sele4.DataSource = scr.GetCrsInfo();
            Course_sele4.DisplayMember = "CourseName";
            Course_sele4.ValueMember = "CourseName";
        }

        public void clearscr()
        {
            Locked = false;
            Std_id2.Text = "";
            score2.Text = "";
            Course_sele4.SelectedIndex = 0;
            scr_desc2.Text = "";
        }

        public void SearchRslt(string keyword)
        {
            try
            {
                score_table2.DataSource = scr.SearchScr(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TableChngr()
        {
            if (radio_students2.Checked)
            {
                ShowStd();
            }
            else
            {
                ShowScore();
            }
        }

        //=========================================================================================================================

        private void ScoreManageForm_Load(object sender, EventArgs e)
        {
            ModuleComboBox();
            ShowStd();
        }

        private void clear_scr3_Click(object sender, EventArgs e)
        {
            clearscr();
        }

        private void radio_students2_CheckedChanged(object sender, EventArgs e)
        {
            TableChngr();
        }

        private void score_table2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radio_score2.Checked)
            {
                Locked = true;
                Std_id2.Text = score_table2.CurrentRow.Cells[0].Value.ToString();
                Course_sele4.Text = score_table2.CurrentRow.Cells[3].Value.ToString();
                score2.Text = score_table2.CurrentRow.Cells[4].Value.ToString();
                scr_desc2.Text = score_table2.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void scr_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Locked)
                {

                }

                else if (Std_id2.Text == "" || score2.Text == "")
                {
                    MessageBox.Show("Need score data!", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    scr.Id = Convert.ToInt32(Std_id2.Text);
                    scr.Cname = Course_sele4.Text;
                    scr.Scor = Convert.ToInt32(score2.Text);
                    scr.Descr = scr_desc2.Text;

                    if (scr.updateScore())
                    {
                        MessageBox.Show("Score Edit Completed!", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowScore();
                        clearscr();
                    }
                    else
                    {
                        MessageBox.Show("Score not edited!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            } catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scr_del_Click(object sender, EventArgs e)
        { 
            if (Locked)
            {
                DialogResult Result = MessageBox.Show("Confirm to Delete?", "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    scr.Id = Convert.ToInt32(Std_id2.Text);
                    scr.Cname = Course_sele4.Text;
                    if (scr.deleteScore())
                    {
                        MessageBox.Show("Delete Successful! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowScore();
                        clearscr();
                    }
                    else
                    {
                        MessageBox.Show("Score not Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void Search_scr2_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_scr2.Text);
        }
    }


}
