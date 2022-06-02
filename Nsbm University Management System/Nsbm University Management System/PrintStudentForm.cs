using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace Nsbm_University_Management_System
{
    public partial class PrintStudentForm : Form
    {
        Students std = new Students();
        DGVPrinter printer = new DGVPrinter();

        public PrintStudentForm()
        {
            InitializeComponent();
        }

        //===================================================== reusable ==========================================

        public void ShowInfo()
        {
            try
            {
                std_table_print.DataSource = std.GetStdInfo();
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table_print.Columns[7];
                Imgcolmn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowPrintList(string keyword)
        {
            try
            {
                std_table_print.DataSource = std.getList(keyword);
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table_print.Columns[7];
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
                std_table_print.DataSource = std.SearchStd(keyword);
                DataGridViewImageColumn Imgcolmn = new DataGridViewImageColumn();
                Imgcolmn = (DataGridViewImageColumn)std_table_print.Columns[7];
                Imgcolmn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Print()
        {
            printer.Title = "Allianth Students List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(std_table_print);
        }
        //=====================================================================================================
        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void radio_male3_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrintList("Male");
        }

        private void radio_female3_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrintList("Female");
        }

        private void radio_all_CheckedChanged(object sender, EventArgs e)
        {
            ShowPrintList("All");
        }

        private void print_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Search3_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search3.Text);
        }
    }
}
