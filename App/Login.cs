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
        //private bool loginStatus;
        public Login(MySqlConnection mySqlConnection, string userName, string userPassword)
        {
            SqlConnection = mySqlConnection;
            UserAccount = new User(mySqlConnection);
            UserAccount.Name = userName;
            UserAccount.Password = userPassword;
            
            LoginStatus = Valid();//true or false/private property
        }
        public User UserAccount { get; private set; }
        /// <summary>
        /// is validated?
        /// true = Loggedin
        /// false = NOT loggedin
        /// </summary>
        public bool LoginStatus { get; private set; }
        public MySqlConnection SqlConnection { get; private set; }
        /// <summary>
        ///  returns the user level is admin or normal user
        ///  <para></para>
        ///  false  == normal user
        ///  true == admin
        ///  
        /// </summary>
        /// 
        public bool UserLevel { get; private set; }


        /// <summary>
        /// This method check the user name an the user password ar correct or not.
        /// </summary>
        /// <param name="userName">User name from the user</param>
        /// <param name="userPassword">User password from the user</param>
        /// <returns>Is Validated</returns>
        public bool Valid()
        {

            string query = "SELECT * FROM mydb.user where User_Name='" + UserAccount.Name + "'AND Password='" + UserAccount.Password + "';";


            MySqlDataAdapter MyCommand2 = new MySqlDataAdapter(query, SqlConnection);

            SqlConnection.Open();//<= good practice to open connection when needed and close when not needed

            DataTable dt = new DataTable();
            MyCommand2.Fill(dt);//Fills datatable with query results


            if (dt.Rows.Count == 1)//if there is one user in table means valid 
            {
                //store data
                UserAccount.Name = dt.Rows[0].Field<string>("User_name");
                UserAccount.Password = dt.Rows[0].Field<string>("Password");
                UserAccount.FName = dt.Rows[0].Field<string>("first_name");
                UserAccount.LName = dt.Rows[0].Field<string>("last_name");
                //TODO Confirm the correctness
                UserLevel = (dt.Rows[0].Field<int>("admin")==1)?true:false;
                //TODO remove 
                dt.Clear();//empty dataTable not neccessaryy
                SqlConnection.Close();


                return true;//valid user.

            }
            else
            {
                UserAccount = null;//maybe unneccessary 
                SqlConnection.Close();

                return false;//(password or username incorrect) OR (User not found) OR (multiple users same credintials)

            }


            //GetSqlConnection().Close();

        }

        public List<User> getConnectedUsers()
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
            LoginStatus = false;
            //TODO remove the lines below after checking
            //not part of the Login class
            /*Form1 f = new Form1();
            f.Show();*/


        }
    }
}

