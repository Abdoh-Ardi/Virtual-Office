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
        public void SuccessfullLogin()
        {
            
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "test", "12345a");
            vo.Login("Abdoh123", "123456");//correct password
            
            Assert.IsTrue(vo.LoginStatus);
            
        }

        [TestMethod]
        public void failLogin()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "test", "12345a");
            vo.Login("Abdoh", "1234567");//incorrect password
            Assert.IsFalse(vo.LoginStatus);
        }

        [TestMethod]
        public void adminLogin()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "test", "12345a");
            vo.Login("abdoh123", "123456");//correct password
            Debug.WriteLine(vo.manageLogin.UserLevel);
            Assert.IsTrue(vo.manageLogin.UserLevel);
            
        }

        [TestMethod]
        public void userLogin()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "test", "12345a");
            vo.Login("test", "123456");//correct password
            Assert.IsFalse(vo.manageLogin.UserLevel);

        }

    }
}