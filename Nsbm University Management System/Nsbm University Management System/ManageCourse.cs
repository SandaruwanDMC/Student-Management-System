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
    public partial class ManageCourse : Form
    {
        Courses crs = new Courses();

        bool Locked;
        public ManageCourse()
        {
            InitializeComponent();
        }

        private void ManageCourse_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        //============================================================= reusable -=================================================

        public void ShowInfo()
        {
            try
            {
                crs_table2.DataSource = crs.GetCrsInfo();
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
                crs_table2.DataSource = crs.SearchCrs(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Validate2()
        {
            if (!Locked)
            {
                return false;
            }

            if (crs_id2.Text == "" || crs_name2.Text == "" || crs_desc2.Text == "" || hours2.Text == "")
            {
                MessageBox.Show(" Please fill all fields! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        public void ClearData()
        {
            Locked = false;
            crs_id2.Text = "";
            crs_name2.Text = "";
            crs_desc2.Text = "";
            hours2.Text = "";
        }

        //========================================================================================================================================

        private void clear_crs2_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void update_crs_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate2())
                {
                    crs.Cid = Convert.ToInt32(crs_id2.Text);
                    crs.Cname = crs_name2.Text;
                    crs.Hours = Convert.ToInt32(hours2.Text);
                    crs.Desc = crs_desc2.Text;

                    if (crs.updateCourse())
                    {
                        MessageBox.Show("Update Successful! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        ShowInfo();
                    }
                    else
                    {
                        MessageBox.Show("Update failed! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void delete_crs_Click(object sender, EventArgs e)
        {
            if (Locked)
            {
                DialogResult Result = MessageBox.Show("Confirm to Delete?", "Warring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    crs.Cid = Convert.ToInt32(crs_id2.Text);
                    crs.deletCourse();
                    MessageBox.Show("Delete Successful! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearData();
                    ShowInfo();
                }
                else if ((Result == DialogResult.No))
                {
                    return;
                }

            }
        }

        private void crs_table2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Locked = true;
            crs_id2.Text = crs_table2.CurrentRow.Cells[0].Value.ToString();
            crs_name2.Text = crs_table2.CurrentRow.Cells[1].Value.ToString();
            hours2.Text = crs_table2.CurrentRow.Cells[2].Value.ToString();
            crs_desc2.Text = crs_table2.CurrentRow.Cells[3].Value.ToString();
        }

        private void Search_crs2_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_crs2.Text);
        }
    }
}
