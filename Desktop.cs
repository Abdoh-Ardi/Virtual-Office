using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    class Desktop
    {
        public Desktop()
        {

        }
        public Desktop(string desktopName, string loginName, string loginPassword, string desktopAddress) { } //not completed 


        public void connect(string loginName, string loginPassword, string desktopAddress) { } //not completed 

        public void disconnect() { } //not completed 


        public string[] desktopName = new string[10];
        public string[] DesktopName
        {
            get { return desktopName; }
            set { desktopName = value; }
        }


        public string[] loginName = new string[10];
        public string[] LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }


        public string[] loginPassword = new string[10];
        public string[] LoginPassword
        {
            get { return loginPassword; }
            set { loginPassword = value; }
        }


        public string[] desktopAddress = new string[10];
        public string[] DesktopAddress
        {
            get { return desktopAddress; }
            set { desktopAddress = value; }
        }
    }
}
