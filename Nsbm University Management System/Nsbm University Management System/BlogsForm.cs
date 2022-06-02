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
    public partial class BlogsForm : Form
    {
        public BlogsForm()
        {
            InitializeComponent();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            System.Diagnostics.Process.Start("https://uom.lk/competitions/slrc");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.home.sandvik/en/stories/articles/2019/11/5g-is-finally-here-this-is-what-you-need-to-know/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=IT+related+internship+in+virtusa+sri+lanka&spell=1&sa=X&biw=1366&bih=657&dpr=1&ibp=htl;jobs&ved=2ahUKEwiYqo2M6KvzAhUk8XMBHbVMCLMQkd0GegQIBBAB#fpstate=tldetail&htivrt=jobs&htiq=IT+related+internship+in+virtusa+sri+lanka&htidocid=On1bkpAswxpEE6maAAAAAA%3D%3D");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=IT+related+internship+in+mas+sri+lanka&biw=1366&bih=657&ei=-1tYYdjAAqTiz7sPtZmhmAs&oq=IT+related+internship+in+mas+sri+lanka&gs_lcp=Cgdnd3Mtd2l6EAwyBQgAEM0COgcIABBHELADOgQIIRAKSgQIQRgAUIMoWIJGYKtVaAFwAngAgAHmAYgBlQySAQYwLjExLjGYAQCgAQHIAQjAAQE&sclient=gws-wiz&ibp=htl;jobs&sa=X&ved=2ahUKEwjItcKj8KvzAhXR6XMBHW53BUAQkd0GegQIDBAB#fpstate=tldetail&htivrt=jobs&htiq=IT+related+internship+in+mas+sri+lanka&htidocid=dmr0r_MUGnhHjVmXAAAAAA%3D%3D");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nsbm.ac.lk/course/bsc-honours-in-data-science/");
        }
    }
    
}
