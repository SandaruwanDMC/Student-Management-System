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
    public partial class ManageStudentForm : Form
    {
        Students std = new Students();
        bool Locked = false;

        public ManageStudentForm()
        {
            InitializeComponent();
        }
//=========================================================================== reusable ===================================================================

        public void ShowInfo()
        {
            try
            {
                std_table_mng.DataSource = std.GetStdInfo();
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table_mng.Columns[7];
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
                std_table_mng.DataSource = std.SearchStd(keyword);
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table_mng.Columns[7];
                Imgcolmn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearData()
        {
            Std_id2.Text = "";
            Std_fname2.Text = "";
            Std_lname2.Text = "";
            Std_bday2.Value = DateTime.Parse("1900-01-01"); ;
            radio_male2.Checked = false;
            radio_female2.Checked = false;
            Std_addrs2.Text = "";
            Std_contact2.Text = "";
            Std_img2.Image = null;
            Locked = false;
        }

        public bool Validate2()
        {
            if (!Locked)
            {
                return false;
            }
            else if (Std_id2.Text == "" || Std_fname2.Text == "" || Std_lname2.Text == "" || Std_addrs2.Text == "" || Std_contact2.Text == "" || Std_img2.Image == null
                || (radio_male2.Checked == false && radio_female2.Checked == false))
            {
                MessageBox.Show(" Please fill all fields! ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if ((DateTime.Now.Year - Std_bday2.Value.Year) < 20 || (DateTime.Now.Year - Std_bday2.Value.Year) > 60)
            {
                MessageBox.Show(" Invaild Birthdate!", "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        //====================================================================================================================================================


        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void std_table_mng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Locked = true;
            Std_id2.Text = std_table_mng.CurrentRow.Cells[0].Value.ToString();
            Std_fname2.Text = std_table_mng.CurrentRow.Cells[1].Value.ToString();
            Std_lname2.Text = std_table_mng.CurrentRow.Cells[2].Value.ToString();
            Std_bday2.Value = (DateTime)std_table_mng.CurrentRow.Cells[3].Value;
            if (std_table_mng.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                radio_male2.Checked = true;
            }
            else
            {
                radio_female2.Checked = true;
            }
            Std_contact2.Text = std_table_mng.CurrentRow.Cells[5].Value.ToString();
            Std_addrs2.Text = std_table_mng.CurrentRow.Cells[6].Value.ToString();
            byte[] img = (byte[])std_table_mng.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            Std_img2.Image = Image.FromStream(ms);
        }

        private void clear2_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate2())
                {
                    std.Id = Convert.ToInt32(Std_id2.Text);
                    std.Fname = Std_fname2.Text;
                    std.Lname = Std_lname2.Text;
                    std.Bday = Std_bday2.Value;
                    std.Gen = (radio_male2.Checked ? "Male" : "Female");
                    std.Addrs = Std_addrs2.Text;
                    std.Phone = Std_contact2.Text;
                    MemoryStream m1 = new MemoryStream();
                    Std_img2.Image.Save(m1, Std_img2.Image.RawFormat);
                    std.Img = m1.ToArray();
                    if (std.StdUpdate())
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (Locked)
            {
                DialogResult Result = MessageBox.Show("Confirm to Delete?", "Warring!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Result == DialogResult.Yes)
                {
                    std.Id = Convert.ToInt32(Std_id2.Text);
                    std.StdDelete();
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

        private void Search2_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search2.Text);
        }

        private void Std_img2_Click(object sender, EventArgs e)
        {
            OpenFileDialog d1 = new OpenFileDialog();
            d1.InitialDirectory = "C://Desktop";
            d1.Title = "Select the photo to be upload";
            d1.Filter = "Select the photo(*.jpg; *.png; *.jpeg; *.tiff)|*.jpg; *.png; *.jpeg; *.tiff";
            d1.FilterIndex = 1;
            try
            {
                if (d1.ShowDialog() == DialogResult.OK)
                {
                    if (d1.CheckFileExists)
                    {
                        Std_img2.Image = null;
                        Std_img2.Text = "";
                        Std_img2.Image = Image.FromFile(d1.FileName);
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
    }
}
