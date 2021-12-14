using System;
using System.Collections.Generic;
using System.Text;

namespace MTDhruvRajpara
{
    public class Login
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        private String _username;

        public String Username
        {
            get { return _username; }
            set { _username = value; }
        }

        private String _password;

        public String Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public Login(int id, String username, String password)
        {
            Id = id;
            Username = username;
            Password = password;
        }
    }
}
