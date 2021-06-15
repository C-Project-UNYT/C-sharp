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

        List<Professor> proffessorList = new List<Professor>();
        List<Student> studentList = new List<Student>();
        List<Courses> coursesList = new List<Courses>();

        public Admin()
        {
            this.readFiles();
        }

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
            return username.Equals(this.getUsername());
        }

        public bool passwordValid(string password)
        {
            return password.Equals(this.getPassword());
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

        private void readFiles()
        {

        }
    }

}