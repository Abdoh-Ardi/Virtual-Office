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

        private String userName;
        private String userPassword;
        private string userLevel;//null = user 
        //private bool loginStatus;
        private MySqlConnection mySqlConnection;
        public Login(MySqlConnection mySqlConnection,string userName,string userPassword)
        {
            this.mySqlConnection = mySqlConnection;
            this.userName = userName;
            this.userPassword = userPassword;
            LoginStatus=Valid();//true or false/private property
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }

        }
        /// <summary>
        /// is validated?
        /// true = Loggedin
        /// false = NOT loggedin
        /// </summary>
        public bool LoginStatus{ get; set;}
        public MySqlConnection SqlConnection
        {
            get { return mySqlConnection; }
        }
        /// <summary>
        ///  returns the user level is admin or normal user
        ///  true  == normal user
        ///  false == admin
        ///  change if needed
        /// </summary>
        /// 
        public bool UserLevel
        {
           get { return String.IsNullOrEmpty(userLevel); }
        }

       /// <summary>
       /// This method check the user name an the user password ar correct or not.
       /// </summary>
       /// <param name="userName">User name from the user</param>
       /// <param name="userPassword">User password from the user</param>
       /// <returns>Is Validated</returns>
        public bool Valid()
        {
            //here just change the password to your password...
            //string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=1234m";
            //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            string query = "SELECT * FROM mydb.user where User_Name='" + UserName + "'AND Password='" + UserPassword + "';";

             
            //MySqlDataAdapter MyCommand2 = new MySqlDataAdapter(Query, MyConn2);
            MySqlDataAdapter MyCommand2 = new MySqlDataAdapter(query, SqlConnection);

            SqlConnection.Open();//<= good practice to open connection when needed and close when not needed
                        
            DataTable dt = new DataTable();
            MyCommand2.Fill(dt);//Fills datatable with query results
            

            if (dt.Rows.Count==1)//if there is one user in table means valid 
            {
                userLevel = dt.Rows[0].Field<string>("admin");
                SqlConnection.Close();
                //TODO remove throws
                
                return true;//valid user.
                
            } else
            {
                SqlConnection.Close();
                
                return false;//(password or username incorrect) OR (User not found) OR (multiple users same credintials)
                
            }
           

            //GetSqlConnection().Close();
            
        }

        public void logout()
        {
            LoginStatus = false;
            //TODO remove the lines below after checking
            //not part of the Login class
            Form1 f = new Form1();
            f.Show();
            

        }
    }
}

