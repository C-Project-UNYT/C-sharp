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
        private List<string> courses;

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

        public string Major
        {
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

        public Student(string name, string surname, string username, string password, string major, string studentID) : base(name, surname, username, password)
        {
            this.studentID = studentID;
            this.major = major;
        }


        public bool passwordAndUsernameValidation(string password)
        {
            List<Student> student = 
        }

        public List<Student> readStudentFile()
        {
            List<Student> student = new List<Student>();
            StreamReader input = new StreamReader("StudentFile.txt");
            string line;

            while ((line = input.Read()) != null)
            {
                string word = line.Split(',');
                Student s = new Student(entries[0], entries[1], entries[2], entries[3], entries[4], entries[5], entries[6]);

                for (int i = 7; i < word.Length; i++)
                {
                    s.courses.Add(word[i])
                }

                student.Add(s);
            }
            input.Close();
            return student;
        }

    }
}
