using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using Virtual_Office;

namespace VirtualOfficeUnitTest
{
    [TestClass]
    public class VirtualOfficeDBTest
    {
        [TestMethod]
        public void connect()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Close();//Nologin

            //VirtualOffice vo = VirtualOffice.instance();
            //vo.Server = "localhost";
            //vo.databaseName = "mydb";
            //vo.UserName = "admin";
            //vo.Password = "123456";

            //suppose col0 and col1 are defined as VARCHAR in the DB
            //string query = "SELECT col0,col1 FROM YourTable";
            //var cmd = new MySqlCommand(query, dbCon.Connection);
            //var reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //  string someStringFromColumnZero = reader.GetString(0);
            //string someStringFromColumnOne = reader.GetString(1);
            //Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            //}
        }
    }
}
