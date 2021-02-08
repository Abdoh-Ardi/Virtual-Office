using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Virtual_Office
{
    class Administrator : User
    {

        public void AddDesktop(string desktopName, string loginName, string loginPassword, string desktopAddress)
        {
            //This is my connection string i have assigned the database file address path  
            string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.desktop(ip_address,desktop_name,desktop_password) values('" + desktopAddress + "','" + desktopName + "','" + loginPassword + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();

        }
        public void RemoveDesktop(String desktopAddress)
        {

            string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.desktop where ip_address='" + desktopAddress + "';";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();

        }
        public void Adduser(String userName, String userpassword)
        {
            //This is my connection string i have assigned the database file address path  
            string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.user(User_name,Password) values('" + userName + "','" + userpassword + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();

        }


        public void Removeuser(String userName, String userpassword)
        {
            string MyConnection2 = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.user where User_name='" + userName + "';";
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
            MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader2;
            MyConn2.Open();
            MyReader2 = MyCommand2.ExecuteReader();
            while (MyReader2.Read())
            {
            }
            MyConn2.Close();
        }

        public void DisplayActivityLog() //not completed 
        {
            Console.WriteLine("ActivityLog");
        }

    }


}
