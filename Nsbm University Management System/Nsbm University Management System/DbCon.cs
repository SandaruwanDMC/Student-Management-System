using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nsbm_University_Management_System
{
    class DbCon
    {
            MySqlConnection con = new MySqlConnection("server=localhost; database=studentdb; uid=root;pwd=; SSL Mode=0;");
            public MySqlConnection Getconnection
            {
                get
                {
                    return con;
                }
            }

            public void opencon()
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Closed)
                    {
                        con.Open();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Server Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            public void closecon()
            {
                try
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Server Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
    }
}
