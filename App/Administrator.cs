using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Virtual_Office
{
    class Administrator : User
    {

        public void AddDesktop(string desktopName, string loginName, string loginPassword, string desktopAddress)
        {
            //This is my connection string i have assigned the database file address path  
            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.desktop(ip_address,desktop_name,desktop_login_name,desktop_password) values('" + desktopAddress + "','" + desktopName + "','"+ loginName + "','" + loginPassword + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {

            }
            MyConn.Close();

        }

        public void AddDesktop(string loginName, string loginPassword, string desktopAddress)
        {
            DateTime now = DateTime.Now;
            //This is my connection string i have assigned the database file address path  
            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.desktop(ip_address,desktop_name,desktop_login_name,desktop_password) values('" + desktopAddress + "','" + now + "','" + loginName + "','" + loginPassword + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn2 = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn2);
            MySqlDataReader MyReader;
            MyConn2.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {

            }
            MyConn2.Close();

        }
        public void RemoveDesktop(String desktopAddress)
        {

            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.desktop where ip_address='" + desktopAddress + "';";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
            }
            MyConn.Close();

        }
        public void Adduser(String userName, String userpassword, String first_name, String last_name, String ip_address, String admin, String desktop_ip_address)
        {
            //This is my connection string i have assigned the database file address path  
            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.user(User_name,Password,first_name,last_name,IP_Address,admin,Desktop_ip_address) values('" + userName + "','" + userpassword+ "','" + first_name + "','"+ last_name + "','"+ ip_address + "','" + admin + "','" + desktop_ip_address + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {
            }
            MyConn.Close();

        }


        public void Removeuser(String userName)
        {
            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.user where User_name='" + userName + "';";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
            }
            MyConn.Close();
        }

        public void DisplayActivityLog()
        {
            string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //Display query  
            string Query = "SELECT * FROM mydb.activity;";
            MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, MyConn);
            MyConn.Open();
            MySqlDataReader rdr = MyCommand.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Load(rdr);

            if (dTable.Rows.Count != 0)
            {

                Console.WriteLine(" ActivityLog: ");

                foreach (DataRow row in dTable.Rows)
                {
                    Console.WriteLine();
                    Console.WriteLine("user-type-time ");
                    for (int x = 0; x < dTable.Columns.Count; x++)
                    {
                        Console.Write(row[x].ToString() + "  ");
                    }
                    Console.WriteLine();
                }
            }

            else { Console.WriteLine(" no ActivityLog found "); }

            MyConn.Close();

        }


    }


}
