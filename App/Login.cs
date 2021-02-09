using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Virtual_Office;

namespace Virtual_Office
{
    class Login
    {
        String userName;
        String userPassword;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }

        }

        public String UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }

        }


        public bool Valid(String userName, String userPassword)
        {

            //SqlConnection con = new SqlConnection();
            //SqlCommand cmd;
            //con.Open();
            ////cmd = new SqlCommand("insert into new_table values('" + userName + "','" + userPassword +  ")", con);
            //cmd = new SqlCommand("SELECT * FROM mydb.new_table where userName = 'name' AND userPassword = 'Pass' ", con);
            //cmd.ExecuteNonQuery();
            //int i= cmd.ExecuteNonQuery(); 
            //if (i == 1)
            //{

            //    return true;
            //}
            //else { return false; }


            String user = "Mohammed";
            String password = "1234";
            if (user == userName && password == userPassword)
            {
                return true;
            }// not completed
            else { return false; }
        }

        public void logout()
        {
            
            Form1 f = new Form1();
            f.Show();
            

        }
    }
}

