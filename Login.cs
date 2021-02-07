using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Office
{
    class Login
    {
        String userName;
        String userPassword;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }

        }

        public String UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }

        }


        public void validate(String userName, String userPassword)
        {
            String user = "Mohammed";
            String password = "1234";
            if (user == userName && password == userPassword)
            {

            }// not completed
        }
            public void logout() { }
    }
}

