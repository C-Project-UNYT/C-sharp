using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Student : Person, Login
    {
        public Student(string name, string surname, string username, string password) : base(name, surname, username, password)
        {

        } 

        public bool passwordValid(string password)
        {
            return false;
        }

        public bool usernameValid(string username)
        {
            return false;
        }
    }
}
