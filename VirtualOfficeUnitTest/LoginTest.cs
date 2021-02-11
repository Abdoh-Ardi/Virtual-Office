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
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Login("Abdoh","123456");//correct password
            Assert.IsTrue(vo.LoginStatus);

        }

        [TestMethod]
        public void failLogin()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Login("Abdoh","1234567");//incorrect password
            Assert.IsFalse(vo.LoginStatus);
        }
    }
}