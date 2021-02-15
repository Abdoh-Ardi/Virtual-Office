using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    public class Desktop
    {
        public Desktop(string loginName, string loginPassword, string desktopAddress)//TODO class implementation
        {
            this.loginName = loginName;
            this.loginPassword = loginPassword;
            this.desktopAddress = desktopAddress;
        }
        public Desktop(string desktopName, string loginName, string loginPassword, string desktopAddress) {
            this.desktopName = desktopName;
            this.loginName = loginName;
            this.loginPassword = loginPassword;
            this.desktopAddress = desktopAddress;
        } //TODO class implementation
        public void connect(string loginName, string loginPassword, string desktopAddress) { } ////TODO method connect in Desktop implementation

        public void disconnect() { } //TODO method disconnect in Desktop implementation


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
