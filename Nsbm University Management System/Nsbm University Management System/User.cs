using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsbm_University_Management_System
{
    class User
    {
        private string uname;
        private string passwrd;

        DbCon con = new DbCon();

        public string Uname { get => uname; set => uname = value; }
        public string Passwrd { get => passwrd; set => passwrd = value; }

        public bool Login()
        {
            String Query = "SELECT * FROM `user` WHERE `username`= @usr  AND `password`= @pass";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            Command.Parameters.Add("@usr", MySqlDbType.VarChar).Value = Uname;
            Command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Passwrd;
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            if (Tbl.Rows.Count > 0)
            {
                return true;
            }
                return false;
        }
    }
}
