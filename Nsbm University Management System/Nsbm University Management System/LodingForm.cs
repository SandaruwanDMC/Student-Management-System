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
    public partial class LodingForm : Form
    {
        public LodingForm()
        {
            InitializeComponent();
        }
      
        private void LodingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int ticks = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks += 1;
            Progress.Start();
            if (ticks > 40)
            {
                LoginForm login = new LoginForm();
                Progress.Stop();
                timer1.Stop();
                this.Hide();
                login.Show();
            }

        }
    }
}
