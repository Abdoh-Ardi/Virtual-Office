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
            Login log = new Login();
            Assert.IsTrue(log.Valid("Moh", "1222"));
        }
    }
}