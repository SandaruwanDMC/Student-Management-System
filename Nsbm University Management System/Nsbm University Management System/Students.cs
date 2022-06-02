using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsbm_University_Management_System
{
    class Students : University
    {
        private int id;
        private string fname;
        private string lname;
        private DateTime bday;
        private string gen;
        private string phone;
        private string addrs;
        private byte[] img;

        public int Id { get => id; set => id = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public DateTime Bday { get => bday; set => bday = value; }
        public string Gen { get => gen; set => gen = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Addrs { get => addrs; set => addrs = value; }
        public byte[] Img { get => img; set => img = value; }

        DbCon con = new DbCon();

        public bool StdRegister()
        {
            string Query = "INSERT INTO `student` ( `Stdid`, `StdFirstName`, `StdLastName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES (@id,@fn,@ln,@bd,@gn,@tl,@ad,@img)";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            Command.Parameters.Add("@id", MySqlDbType.Int32).Value =Id ;
            Command.Parameters.Add("@fn", MySqlDbType.VarChar).Value =Fname;
            Command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname;
            Command.Parameters.Add("@bd", MySqlDbType.Date).Value = Bday;
            Command.Parameters.Add("@gn", MySqlDbType.VarChar).Value =Gen ;
            Command.Parameters.Add("@tl", MySqlDbType.VarChar).Value =Phone;
            Command.Parameters.Add("@ad", MySqlDbType.VarChar).Value =Addrs;
            Command.Parameters.Add("@img", MySqlDbType.Blob).Value =Img ;
            con.opencon();
            if (Command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            con.closecon();
            return false;
        }


        public bool StdUpdate()
        {
            string Query = "UPDATE `student` SET `StdFirstName`=@fn,`StdLastName`=@ln, `Birthdate`=@bd,`Gender`=@gn,`Phone`=@tl, `Address`=@ad,`Photo`=@img WHERE `Stdid`=@id";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            Command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = Fname;
            Command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = Lname;
            Command.Parameters.Add("@bd", MySqlDbType.Date).Value = Bday;
            Command.Parameters.Add("@gn", MySqlDbType.VarChar).Value = Gen;
            Command.Parameters.Add("@tl", MySqlDbType.VarChar).Value = Phone;
            Command.Parameters.Add("@ad", MySqlDbType.VarChar).Value = Addrs;
            Command.Parameters.Add("@img", MySqlDbType.Blob).Value = Img;
            Command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            con.opencon();
            if (Command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            con.closecon();
            return false;
        }


        public bool StdDelete()
        {
            string Query = "DELETE FROM `student` WHERE `Stdid`=@id";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            Command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            con.opencon();
            if (Command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            con.closecon();
            return false;
        }


        public DataTable GetStdInfo()
        {
            MySqlCommand Command = new MySqlCommand("SELECT * FROM `student`", con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }


        public DataTable SearchStd(string keyword)
        {
            string Query = $"SELECT * FROM `student` WHERE `Stdid` LIKE '%{keyword}%' OR `StdFirstName` LIKE '%{keyword}%' OR `StdLastName` LIKE '%{keyword}%' OR `Birthdate` LIKE '%{keyword}%' OR `Gender` Like '%{keyword}%' OR `Phone` LIKE '%{keyword}%' OR `Address` LIKE '%{keyword}%'";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }

        //====================================== uncompleted ==========================================
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, con.Getconnection);
            con.opencon();
            string count = command.ExecuteScalar().ToString();
            con.closecon();
            return count;
        }
      
        public string totalStudent(string module)
        {
            if (module == "Total Students" || module == "")
            {
                return exeCount("SELECT COUNT(*) FROM student");
            }
            string query = "SELECT COUNT(*) FROM student";
            return exeCount(query);
        }
       

        public string maleStudent(string module)
        {
            if (module == "Total Students" || module == "")
            {
                return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`='Male'");
            }
            string query = "SELECT COUNT(*) FROM student WHERE `Gender`= 'Male'";
            return exeCount(query);
        }
        

        public string femaleStudent(string module)
        {
            if (module == "Total Students" || module=="")
            {
                return exeCount("SELECT COUNT(*) FROM student WHERE `Gender`='Female'");
            }
            string query = "SELECT COUNT(*) FROM student WHERE `Gender`='Female'";
            return exeCount(query);
        }
        //=============================================================================================
        public DataTable getList(string keyword)
        {
            string Query;
            if (keyword == "All")
            {
                Query = $"SELECT * FROM `student`";
            }
            else
            {
                Query = $"SELECT * FROM `student` WHERE `Gender` = '{keyword}'";
            }
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getSdt()
        {
            string Query = "SELECT `Stdid`,`StdFirstName`,`StdLastName` FROM `student`";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(Command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
