using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    class Administrator : User
    {
        private Desktop desktop;

        public void AddDesktop(string desktopName, string loginName, string loginPassword, string desktopAddress)
        {
            for (int i = 0; i < desktop.DesktopAddress.Length; i++)
            {
                if (desktop.DesktopAddress[i] == null)
                {
                    desktop.DesktopName[i] = desktopName;
                    desktop.LoginName[i] = loginName;
                    desktop.LoginPassword[i] = loginPassword;
                    desktop.DesktopAddress[i] = desktopAddress;

                }
            }
        }
        public void RemoveDesktop(String desktopAddress)
        {


            for (int i = 0; i < desktop.DesktopAddress.Length; i++)
            {
                if (desktop.DesktopAddress[i] == desktopAddress)
                {
                    desktop.DesktopAddress[i] = null;
                }
            }

        }
        public void Adduser(String userName, String userpassword)
        {
            for (int i = 0; i < UserName.Length; i++)
            {
                if (UserName[i] == null)
                {
                    UserName[i] = userName;
                    Userpassword[i] = userpassword;
                }
            }
        }


        public void Removeuser(String userName, String userpassword)
        {
            for (int i = 0; i < UserName.Length; i++)
            {
                if (UserName[i] == userName)
                {
                    if (Userpassword[i] == userpassword)
                    {
                        UserName[i] = userName;
                        Userpassword[i] = userpassword;
                    }

                }
            }
        }

        public void DisplayActivityLog() //not completed 
        {
            Console.WriteLine("ActivityLog");
        }

    }


}
