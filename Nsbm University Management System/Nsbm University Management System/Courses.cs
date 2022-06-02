using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsbm_University_Management_System
{
    class Courses: Students
    {
        private int cid;
        private string cname;
        private string desc;
        private int hours;
        DbCon con = new DbCon();

        public int Cid { get => cid; set => cid = value; }
        public string Cname { get => cname; set => cname = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Hours { get => hours; set => hours = value; }

        public bool AddCourse()
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `course`(`CourseId`, `CourseName`, `CourseHour`, `Description`) VALUES (@cid,@cn,@ch,@desc)", con.Getconnection);
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = Cid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@ch", MySqlDbType.VarChar).Value = Hours;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Desc;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }
        }

        public DataTable GetCrsInfo()
        {

            MySqlCommand Command = new MySqlCommand("SELECT * FROM `course`", con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }

        public DataTable SearchCrs(string keyword)
        {
            string Query = $"SELECT * FROM `course` WHERE `CourseId` LIKE '%{keyword}%' OR `CourseName` LIKE '%{keyword}%' OR `CourseHour` LIKE '%{keyword}%' OR `Description` LIKE '%{keyword}%'";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }


        public bool updateCourse()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `course` SET `CourseName`=@cn,`CourseHour`=@ch,`Description`=@desc WHERE  `CourseId`=@id", con.Getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Cid;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@ch", MySqlDbType.Int32).Value = Hours;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Desc;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }
        }
       
        public bool deletCourse()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `course` WHERE `CourseId`=@id", con.Getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value =Cid;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }
        }
    }
}
