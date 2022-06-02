using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsbm_University_Management_System
{
    class Scores : Courses
    {
       
       
        private double scor;
        private string descr;

        DbCon con = new DbCon();

     
        public double Scor { get => scor; set => scor = value; }
        public string Descr { get => descr; set => descr = value; }


     
        public bool insertScore()
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `score`(`Stdid`, `CourseName`, `Score`, `Description`) VALUES (@stid,@cn,@sco,@desc)", con.Getconnection);
            //@stid,@cn,@sco,@desc
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = Id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = Scor;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Descr;
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

        public DataTable SearchScr(string keyword)
        {
            string Query = $"SELECT score.Stdid, student.StdFirstName, student.StdLastName, score.CourseName, score.Score, score.Description FROM student INNER JOIN score ON score.Stdid = student.Stdid WHERE CONCAT( score.Stdid ,student.StdFirstName, student.StdLastName, score.CourseName)LIKE '%{keyword}%' ";
            MySqlCommand Command = new MySqlCommand(Query, con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }

        public DataTable GetScrInfo()
        {
            string Qeary = "SELECT score.Stdid,student.StdFirstName,student.StdLastName,score.CourseName,score.Score,score.Description FROM student INNER JOIN score ON score.Stdid=student.Stdid";
            MySqlCommand Command = new MySqlCommand(Qeary, con.Getconnection);
            MySqlDataAdapter Adptr = new MySqlDataAdapter(Command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            return Tbl;
        }
        public bool checkScore()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `score` WHERE `Stdid`= @stid AND `CourseName`= @cn", con.Getconnection);
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = Id;
            command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = Cname;
            MySqlDataAdapter Adptr = new MySqlDataAdapter(command);
            DataTable Tbl = new DataTable();
            Adptr.Fill(Tbl);
            if (Tbl.Rows.Count > 0)
            { 
                return true; 
            }
            return false; 
        }
       

        public bool updateScore()
        {
            MySqlCommand command = new MySqlCommand("UPDATE `score` SET `Score`=@sco,`Description`=@desc WHERE `Stdid`=@stid AND `CourseName`=@scn", con.Getconnection);
            //@stid,@sco,@desc
            command.Parameters.Add("@scn", MySqlDbType.VarChar).Value = Cname;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = Id;
            command.Parameters.Add("@sco", MySqlDbType.Double).Value = Scor;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = Descr;
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
        

        public bool deleteScore()
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `score` WHERE `Stdid`=@id AND `CourseName`=@scn", con.Getconnection);

            //@id
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            command.Parameters.Add("@scn", MySqlDbType.VarChar).Value = Cname;

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
