using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_MK.I
{
    public class Login
    {
        private string _username;
        private string _password;




        public Login(string username, string password)
        {
            _username = username;
            _password = password;


        }


        public string GetUserName { get { return _username; } set { _username = value; } }

        public string GetPassword { get { return _password; } set { _password = value; } }
    }
}
