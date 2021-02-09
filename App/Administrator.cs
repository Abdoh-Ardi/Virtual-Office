using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Virtual_Office
{
    class Administrator : User
    {
        private Desktop desktop;

        public void AddDesktop(string desktopName, string loginName, string loginPassword, string desktopAddress)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.Open();
            cmd=new SqlCommand("insert into Desktop values('" + desktopName + "','" + loginName + "','" + loginPassword + "','" + desktopAddress + ")",con);
            cmd.ExecuteNonQuery();
            con.Close();            
            
        }
        public void RemoveDesktop(String desktopAddress)
        {

            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Desktop WHERE desktopAddress=@ip_address ", con);
            cmd.Parameters.AddWithValue("@ip_address", desktopAddress);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public void Adduser(String userName, String userpassword)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd;
            con.Open();
            cmd = new SqlCommand("insert into User values('" + userName + "','" + userpassword + ")", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void Removeuser(String userName, String userpassword)
        {
            SqlConnection con = new SqlConnection();
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM User WHERE userName=@User_Name ", con);
            cmd.Parameters.AddWithValue("@User_Name", userName);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("DELETE FROM User WHERE userpassword=@Password ", con);
            cmd1.Parameters.AddWithValue("@Password", userpassword);
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        public void DisplayActivityLog() //not completed 
        {
            Console.WriteLine("ActivityLog");
        }

    }


}
