using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Admin : Login
    {
        private static string username = "admin";
        private static string password = "admin123";

        public string getUsername()
        {
            return username;
        }

        public string getPassword()
        {
            return password;
        }

        public bool usernameValid(string username)
        {
            if (username.Equals(this.getUsername()))
                return true;
            return false;
        }

        public bool passwordValid(string password)
        {
            if (password.Equals(this.getPassword()))
                return true;
            return false;
        }

        public void addProfessor()
        {

        }
        public void removeProfessor()
        {

        }
        public void addStudent()
        {

        }
        public void removeStudent()
        {

        }
        public void addCourse()
        {

        }
        public void removeCourse()
        {

        }
    }

}
