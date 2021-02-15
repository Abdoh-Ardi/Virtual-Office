using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    public class User
    {
        public MySqlConnection Connection;
        public User()
        {

        }
        public User(MySqlConnection connection)
        {
            this.Connection = connection;
        }
        public User(string Name,string Password,string FName,string Lname)
        {
            this.Name = Name;
            this.Password = Password;
            this.FName = FName;
            this.LName = Lname;
        }

        public string Name{get;set; }
        public string Password { get; set; }
        public string FName { get; set; }
        public string LName{ get; set; }

        public virtual List<Desktop> AvaliableDesktop()
        {

            string Query = "SELECT  desktop.* FROM desktop,user " +
                "Where desktop.ip_address = user.Desktop_ip_address AND user.User_name = "+ Name +"; "; 
            MySqlCommand MyCommand = new MySqlCommand(Query, Connection);
            Connection.Open();
            MySqlDataReader reader = MyCommand.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Load(reader);
            Connection.Close();//


            if (dTable.Rows.Count > 0 )
            {

                //
               string a = dTable.Rows[0].Field<string>("");
                List<Desktop> list = new List<Desktop>();
                    list.Add(new Desktop(dTable.Rows[0].Field<string>("ip_address")
                        , dTable.Rows[0].Field<string>("desktop_login_name")
                        , dTable.Rows[0].Field<string>("desktop_password")));

                return list;
            }

            else 
            { 
                //
                return null;
            }

        }


        //public string EmpID { get; set; }


    }
}
