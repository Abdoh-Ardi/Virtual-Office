using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using Virtual_Office;

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
            Assert.IsTrue(vo.loginStatus);

            //Assert.IsFalse(vo.loginStatus);// to test empty user

            //Login log = new Login();
            //Assert.IsTrue(log.Valid("Moh", "1222"));
        }
    }
}