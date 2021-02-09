using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Virtual_Office;
using MySql.Data.MySqlClient;
using System.Data;

namespace Virtual_Office
{
   public class Login
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

       /// <summary>
       /// This method check the user name an the user password ar correct or not.
       /// </summary>
       /// <param name="userName">User name from the user</param>
       /// <param name="userPassword">User password from the user</param>
       /// <returns></returns>
        public bool Valid(String userName, String userPassword)
        {
            //here just change the password to your password...
            string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=1234m";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            string Query = "SELECT * FROM mydb.user where User_Name='" + userName + "'AND Password='" + userPassword + "';";

             
            MySqlDataAdapter MyCommand2 = new MySqlDataAdapter(Query, MyConn2);
            MyConn2.Open();
                        
            DataTable dt = new DataTable();
            MyCommand2.Fill(dt);
            

            if (dt.Rows.Count==1)
            {

                    return true;
                
            }
                else { return false;
                MyConn2.Close();
            }
           

            MyConn2.Close();
            
        }

        public void logout()
        {
            
            Form1 f = new Form1();
            f.Show();
            

        }
    }
}

