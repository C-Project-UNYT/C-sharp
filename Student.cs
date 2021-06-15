using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROJECT
{
    class Student : Person, Login
    {
        private string major;
        private string studentID;

        string StudentID
        {
            set
            {
                studentID = value;
            }

            get
            {
                return studentID;
            }
        }

        string Major {
            set
            {
                major = value;
            }

            get
            {
                return major;
            }
        }

        public Student(string name, string surname, string username, string password, string major, string studentID) : base(name, surname, username, password)
        {
            this.studentID = studentID;
            this.major = major;
        }

        public bool passwordValid(string password)
        {
            return false;
        }

        public bool usernameValid(string username)
        {
            return false;
        }

        public void showAllCourses()
        {
            StreamReader file = new StreamReader(@"c:\test.txt");
            while ((line = file.ReadLine()) != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

        }
    }
}
