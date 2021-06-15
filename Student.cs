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
        private string[] courses;

        public string StudentID
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

        public string Major {
            set
            {
                major = value;
            }

            get
            {
                return major;
            }
        }

        public string[] Courses
        {
            set
            {
                courses = value;
            }

            get
            {
                return courses;
            }
        }


        public Student(string name, string surname, string username, string password, string major, string studentID, string courses) : base(name, surname, username, password)
        {
            this.studentID = studentID;
            this.major = major;
            this.courses = courses;
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

            string line = file.ReadLine();
            string[] sub = line.split(",");

            while ( != null)
            {
                System.Console.WriteLine(line);
                counter++;
            }

        }
    }
}
