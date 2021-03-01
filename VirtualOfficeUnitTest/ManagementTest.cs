using System.Text;
using MySql.Data.MySqlClient;
using Virtual_Office;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace VirtualOfficeUnitTest
{
    [TestClass]
    public class ManagementTest
    {

        [TestMethod]
        public void AddDesktops()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "********", "admin", "******");
            vo.Login("abdu", "*******");//admin account
            vo.AddDesktop("khalid", "loginName", "******", "192.0.0.1");
            List<Desktop> list = vo.ShowDesktops();
            bool isAdd = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].desktopAddress == "192.0.0.1")
                {
                    isAdd = true;
                    break;
                }

            }
            Assert.IsTrue(isAdd);




        }


        [TestMethod]
        public void RemoveDesktop()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "*****", "admin", "*******");
            vo.Login("abdu", "*******");//admin account
            vo.RemoveDesktop("192.0.0.1");
            List<Desktop> list = vo.ShowDesktops();
            bool isAdd = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].desktopAddress == "192.0.0.1")
                {
                    isAdd = true;
                    break;
                }

            }
            Assert.IsFalse(isAdd);
        }

        [TestMethod]
        public void AddUser()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "****", "admin", "******");
            vo.Login("abdu", "******");//admin login
            vo.AddUser("khaild", "******", "kha", "alsu", "192.0.0.1", "false", "192.0.0.1");
            vo.Close();
            vo.Login("khaild", "******");//test the new user
            Assert.IsTrue(vo.LoginStatus);

        }


        [TestMethod]
        public void RemoveUser()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "****", "admin", "******");
            vo.Login("abdu", "*****");//admin account
            vo.RemoveUser("khaild");
            vo.Close();

            vo.Login("khaild", "******");
            Assert.IsFalse(vo.LoginStatus);

        }

        [TestMethod]
        public void ShowConnectedUsers()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "****", "admin", "******");
            vo.Login("abdu", "*****");//admin account
            vo.manageLogin.getConnectedUsers();
            Assert.AreEqual(3, vo.manageLogin.getConnectedUsers().Count);
        }


        [TestMethod]
        public void DisplayActivityLog()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "*******");
            vo.Login("abdu", "***********");//admin account
             
            Assert.AreEqual(null, ((Administrator)vo.manageLogin.UserAccount).DisplayActivityLog().Count);

        }


    }

}
