using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    class Desktop
    {
        public Desktop(string loginName, string loginPassword, string desktopAddress)
        {

        }
        public Desktop(string desktopName, string loginName, string loginPassword, string desktopAddress) { } //not completed 
        public void connect(string loginName, string loginPassword, string desktopAddress) { } //not completed 

        public void disconnect() { } //not completed 


        public string desktopName ;
        public string DesktopName
        {
            get { return desktopName; }
            set { desktopName = value; }
        }


        public string loginName;
        public string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }


        public string loginPassword;
        public string LoginPassword
        {
            get { return loginPassword; }
            set { loginPassword = value; }
        }


        public string desktopAddress ;
        public string DesktopAddress
        {
            get { return desktopAddress; }
            set { desktopAddress = value; }
        }
    }
}
