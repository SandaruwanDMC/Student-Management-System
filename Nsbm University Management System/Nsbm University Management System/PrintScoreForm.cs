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
    public partial class PrintScoreForm : Form
    {
        Scores scr = new Scores();
        DGVPrinter printer = new DGVPrinter();

        public PrintScoreForm()
        {
            InitializeComponent();
        }

        //============================================ Reusable ====================================================

        private void ShowScore()
        {
            score_table_print.DataSource = scr.GetScrInfo();
            if (!radio_score3.Checked)
            {
                radio_score3.Checked = true;
            }
        }

        public void ShowStd()
        {
            try
            {
                score_table_print.DataSource = scr.getSdt();
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
                score_table_print.DataSource = scr.SearchScr(keyword);
            }
            catch (Exception E1)
            {
                MessageBox.Show(E1.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TableChngr()
        {
            if (radio_students3.Checked)
            {
                ShowStd();
            }
            else
            {
                ShowScore();
            }
        }

        public void Print()
        {
            printer.Title = "Allianth Score List";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(score_table_print);
        }

        //============================================================================================================

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            ShowStd();
        }

        private void radio_students3_CheckedChanged(object sender, EventArgs e)
        {
            TableChngr();
        }

        private void Search_scr3_TextChanged(object sender, EventArgs e)
        {
            SearchRslt(Search_scr3.Text);
        }

        private void scr_print_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
