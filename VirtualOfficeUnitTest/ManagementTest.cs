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
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "12345a");
            vo.Login("abdu", "01");//admin account
            vo.AddDesktop("kh", "abdu1", "a0a1254", "1234");
            List<Desktop> list = vo.ShowDesktops();
            bool isAdd = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].desktopAddress == "1234")
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
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "12345a");
            vo.Login("abdu", "01");//admin account
            vo.RemoveDesktop("1234");
            List<Desktop> list = vo.ShowDesktops();
            bool isAdd = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].desktopAddress == "1234")
                {
                    isAdd = true;
                    break;
                }

            }
            Assert.IsTrue(isAdd);
        }

        [TestMethod]
        public void AddUser()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "12345a");
            vo.Login("abdu", "01");//admin account
            //String userName, String userpassword, String first_name, String last_name, String ip_address, String admin, String desktop_ip_address
            //values('" + userName + "','" + userpassword+ "','" + first_name + "','"+ last_name + "','"+ ip_address + "','" + admin + "','" + desktop_ip_address + "');";
            vo.AddUser("khaild", "01234", "kha", "alsu", "54612", "abdu", "777");
            vo.Close();

            vo.Login("khaild", "01234");//correct password
            Assert.IsTrue(vo.LoginStatus);




        }


        [TestMethod]
        public void RemoveUser()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "12345a");
            vo.Login("abdu", "01");//admin account
            vo.RemoveUser("khaild");
            vo.Close();

            vo.Login("khaild", "01234");//correct password
            Assert.IsFalse(vo.LoginStatus);


        }

        [TestMethod]
        public void DisplayActivityLog()
        {
            VirtualOffice vo = new VirtualOffice("localhost", "mydb", "admin", "12345a");
            vo.Login("abdu", "01");//admin account
          //vo.DisplayActivityLog();
          //  Assert.IsNotNull(vo.DisplayActivityLog());


        }


    }

}
