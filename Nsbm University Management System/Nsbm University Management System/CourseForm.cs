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
    public partial class CourseForm : Form
    {
        Courses crs = new Courses();

        public CourseForm()
        {
            InitializeComponent();
        }

        //=================================================================================================================================
        public void ShowInfo()
        {
            try
            {
                crs_table.DataSource = crs.GetCrsInfo();
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
                crs_table.DataSource = crs.SearchCrs(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Validate()
        {

            if (crs_id.Text == "" || crs_name.Text == "" || crs_desc.Text == "" || hours.Text == "")
            {
                MessageBox.Show(" Please fill all fields! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ClearData()
        {
            crs_id.Text = "";
            crs_name.Text = "";
            crs_desc.Text = "";
            hours.Text = "";
            
        }
        //=====================================================================================================================================================================

        private void add_crs_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validate())
                {
                    crs.Cid= Convert.ToInt32(crs_id.Text);
                    crs.Cname = crs_name.Text;
                    crs.Hours = Convert.ToInt32(hours.Text);
                    crs.Desc= crs_desc.Text;
                    if (crs.AddCourse())
                    {
                        MessageBox.Show(" Course Added! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowInfo();
                    }
                    else
                    {
                        MessageBox.Show(" Adding failed! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_crs_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void Search_crs_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_crs.Text);
        }

       
    }
}
