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

        string filePath = ""

        public bool passwordValid(string password)
        {
            return false;
        }

        public bool usernameValid(string username)
        {
            return false;
        }

        public void readStudentFile
        {
            List<Student> student = new List<Student>(); 
            List<string> lines = File.ReadAllLines(filePath).ToList();
            
            foreach(string line in lines){
                 string[] entries = line.Split(',');
                 Student s = new Student(entries[0], entries[1], entries[2], entries[3], entries[4], entries[5], entries[6], entries[7], entries[8], entries[9])
    }

        StreamReader file = new StreamReader(@"C:\Users\Utente\Documents\GitHub\C-sharp\Student.txt");

    }
    public void showAllCourses()
        {

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
