using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsbm_University_Management_System
{
    public partial class RegisterForm : Form
    {
        Students std = new Students();
        public RegisterForm()
        {
            InitializeComponent();
        }
//===================================================================== Reusable ====================================================================================
        public void ShowInfo()
        {
            try
            {
                std_table.DataSource = std.GetStdInfo();
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table.Columns[7];
                Imgcolmn.ImageLayout = DataGridViewImageCellLayout.Zoom;
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
                std_table.DataSource = std.SearchStd(keyword);
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table.Columns[7];
                Imgcolmn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Validate()
        {

            if (Std_id.Text == "" || Std_fname.Text == "" || Std_lname.Text == "" || Std_addrs.Text == "" || Std_contact.Text == "" || Std_img.Image == null
                || (radio_male.Checked == false && radio_female.Checked == false))
            {
                MessageBox.Show(" Please fill all fields! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((DateTime.Now.Year - Std_bday.Value.Year) < 15 || (DateTime.Now.Year - Std_bday.Value.Year) > 100)
            {
                MessageBox.Show(" Invaild Birthdate!", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void ClearData()
        {
            Std_id.Text = "";
            Std_fname.Text = "";
            Std_lname.Text = "";
            Std_bday.Value = DateTime.Parse("1900-01-01"); ;
            radio_male.Checked = false;
            radio_female.Checked = false;
            Std_addrs.Text = "";
            Std_contact.Text = "";
            Std_img.Image = null;
        }

     //============================================================================================================================================================

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (Validate())
                {
                    std.Id=Convert.ToInt32(Std_id.Text);
                    std.Fname=Std_fname.Text;
                    std.Lname=Std_lname.Text;
                    std.Bday=Std_bday.Value;
                    std.Gen=(radio_male.Checked ? "Male" : "Female");
                    std.Addrs=Std_addrs.Text;
                    std.Phone=Std_contact.Text;
                    MemoryStream m1 = new MemoryStream();
                    Std_img.Image.Save(m1, Std_img.Image.RawFormat);
                    std.Img=m1.ToArray();
                    if (std.StdRegister())
                    {
                        MessageBox.Show(" Student Registration Successful! ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowInfo();
                    }
                    else
                    {
                        MessageBox.Show(" Student Registration failed! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upload_img_Click(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void Std_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            d1.InitialDirectory = "C://Desktop";
            d1.Title = "Select the photo to be upload";
            d1.Filter = "Select the photo(*.jpg; *.png; *.jpeg; *.tiff)|*.jpg; *.png; *.jpeg; *.tiff";
            d1.FilterIndex = 1;
            try
            {
                if (d1.ShowDialog() ==DialogResult.OK)
                {
                    if (d1.CheckFileExists)
                    {
                        Std_img.Image = null;
                        Std_img.Text = "";
                        Std_img.Image = Image.FromFile(d1.FileName);
                        MessageBox.Show("Photo Uploaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a photo!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search1_TextChanged(object sender, EventArgs e)
        {

            SearchRslt(Search1.Text);
        }
    }
}
