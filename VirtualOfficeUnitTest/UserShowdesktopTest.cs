using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Virtual_Office;
using System.Diagnostics;

namespace VirtualOfficeUnitTest
{
    [TestClass]
    public class UserShowdesktopTest
    {
        [TestMethod]
        public void UserDesktops()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Login("Abdoh", "123456");//user account
            List<Desktop> list = vo.ShowDesktops();
            Debug.WriteLine(list.Count);
            Assert.IsNotNull(list);

        }
        [TestMethod]
        public void AdminTest()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "123456");
            vo.Login("test", "pass");//admin account
            List<Desktop> list = vo.ShowDesktops();
            Debug.WriteLine(list.Count);
            Assert.IsNotNull(list);
        }
    }
}
