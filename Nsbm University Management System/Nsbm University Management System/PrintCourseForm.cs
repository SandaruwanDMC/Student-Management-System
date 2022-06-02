using DGVPrinterHelper;
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
    public partial class PrintCourseForm : Form
    {
        Courses crs = new Courses();
        DGVPrinter printer = new DGVPrinter();

        public PrintCourseForm()
        {
            InitializeComponent();
        }

        //==========================================================================================================================

        public void ShowInfo()
        {
            try
            {
                crs_table3.DataSource = crs.GetCrsInfo();
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
                crs_table3.DataSource = crs.SearchCrs(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Print()
        {
            printer.Title = "Allianth Courses List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(crs_table3);
        }
        //===========================================================================================================================


        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }

        private void print_crs_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Search_crs3_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_crs3.Text);
        }
    }
}
