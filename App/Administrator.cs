using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Virtual_Office
{
    public sealed class Administrator : User
    {

        public Administrator(MySqlConnection mySqlConnection)
        {
            this.Connection=mySqlConnection;
        }
        public override List<Desktop> AvaliableDesktop()
        {

            string Query = "SELECT  desktop.* FROM desktop;";
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            Connection.Open();
            MySqlDataReader reader = MyCommand.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Load(reader);
            Connection.Close();//
            //TODO allow (multiple) data to be stored in LIST
            throw new NotImplementedException("Administrator: This method is not yet implemented");

            List<Desktop> list = new List<Desktop>();
            if (dTable.Rows.Count != 0)
            {

                
              //TODO check if its work
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    Desktop table = new Desktop();

                    table.desktopAddress = dTable.Rows[i]["ip_address"].ToString();
                    table.desktopName = dTable.Rows[i]["desktop_name"].ToString();
                    table.loginName = dTable.Rows[i]["desktop_login_name"].ToString();
                    table.loginPassword = dTable.Rows[i]["ip_address"].ToString();
                    list.Add(table);
                }

                return list;
            }
            else
            {
                //
                return null;
            }


        }
        public void AddDesktop(string desktopName, string loginName, string loginPassword, string desktopAddress)
        {
            //This is my connection string i have assigned the database file address path  
            //string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.desktop(ip_address,desktop_name,desktop_login_name,desktop_password) values('" + desktopAddress + "','" + desktopName + "','"+ loginName + "','" + loginPassword + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            //MySqlConnection MyConn = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            MySqlDataReader MyReader;
            Connection.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {

            }
            Connection.Close();

        }

        public void AddDesktop(string loginName, string loginPassword, string desktopAddress)
        {
            DateTime now = DateTime.Now;

            AddDesktop(now + "-" + now.Millisecond, loginName, loginPassword, desktopAddress);

        }
        public void RemoveDesktop(String desktopAddress)
        {

            //string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.desktop where ip_address='" + desktopAddress + "';";
            //MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            MySqlDataReader MyReader;
            Connection.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
            }
            Connection.Close();

        }
        public void Adduser(String userName, String userpassword, String first_name, String last_name, String ip_address, String admin, String desktop_ip_address)
        {
            //This is my connection string i have assigned the database file address path  
            ///string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into mydb.user(User_name,Password,first_name,last_name,IP_Address,admin,Desktop_ip_address) values('" + userName + "','" + userpassword+ "','" + first_name + "','"+ last_name + "','"+ ip_address + "','" + admin + "','" + desktop_ip_address + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            ///MySqlConnection MyConn = new MySqlConnection(MyConnection);
            //This is command class which will handle the query and connection object.  
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            MySqlDataReader MyReader;
            Connection.Open();
            MyReader = MyCommand.ExecuteReader();     // Here our query will be executed and data saved into the database.  
            while (MyReader.Read())
            {
            }
            Connection.Close();

        }


        public void Removeuser(String userName)
        {
            //string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            string Query = "delete from mydb.user where User_name='" + userName + "';";
            //MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            MySqlDataReader MyReader;
            Connection.Open();
            MyReader = MyCommand.ExecuteReader();
            while (MyReader.Read())
            {
            }
            Connection.Close();
        }

        public List<DataTable> DisplayActivityLog()
        {
            ///string MyConnection = "datasource=localhost;port=3306;username=admin;password=12345a";
            //Display query  
            string Query = "SELECT * FROM mydb.activity;";
            ///MySqlConnection MyConn = new MySqlConnection(MyConnection);
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            Connection.Open();
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

            Connection.Close();
            //TODO remove null 
            return null;
        }

        
    }


}
