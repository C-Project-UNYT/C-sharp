using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Admin : Login
    {
        public bool usernameValid(string username)
        {
            if (username.Equals("admin"))
                return true;
            return false;
        }

        public bool passwordValid(string password)
        {
            if (password.Equals("admin123"))
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
