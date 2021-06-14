using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Professor : Person, Login
    {

        public Professor(string name, string surname, string username, string password) : base(name, surname, username, password)
        {

        }

        public bool passwordValid()
        {
            return false;
        }

        public bool usernameValid()
        {
            return false;
        }
    }
}
