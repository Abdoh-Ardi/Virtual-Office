using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Virtual_Office;
using System.Diagnostics;

namespace VirtualOfficeUnitTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void Isvalid()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Login("Abdoh","123456");//insert userlogin data for test
            //remove comment
            Debug.WriteLine("Test: "+vo.LoginStatus);
            
            Assert.IsTrue(vo.LoginStatus);


            //Assert.IsFalse(vo.loginStatus);// to test empty user

            //Login log = new Login();
            //Assert.IsTrue(log.Valid("Moh", "1222"));
        }
    }
}