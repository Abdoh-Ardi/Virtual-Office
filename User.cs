using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    class User
    { //new 
        public string[] fName = new string[10];
        public string[] UserName
        {
            get { return fName; }
            set { fName = value; }
        }


        public string[] lName = new string[10];
        public string[] LName
        {
            get { return lName; }
            set { lName = value; }
        }


        public string[] empID = new string[10];
        public string[] EmpID
        {
            get { return empID; }
            set { empID = value; }
        }


        public string[] userpassword = new string[10];
        public string[] Userpassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }

    }
}
