using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Virtual_Office;

namespace VirtualOfficeUnitTest
{
    [TestClass]
    public class VirtualOfficeDB
    {
        [TestMethod]
        public void connect()
        {
            VirtualOffice vo = new VirtualOffice("127.0.0.1:3306", "mydb", "testUser", "123456"); 
            //shows errors 

        }
    }
}
