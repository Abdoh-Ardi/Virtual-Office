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
            VirtualOffice vo = new VirtualOffice("localhost:3306", "mydb", "admin", "123456"); 
            //fileNotFound errors 

        }
    }
}
