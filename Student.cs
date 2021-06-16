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
        public string major;
        public string studentID;
        public List<string> courses;
        
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

        public List<string> Courses
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

        public Student(string name, string surname, string username, string password, string major, string studentID, List<String> courses) : base(name, surname, username, password)
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

        public Student(string username, string password)
        {
            if (isUsernameAndPasswordValid(username, password))
            {
                this.Username = username;
                this.Password = password;

                foreach (Student stud in readStudentFile())
                {
                    if (stud.Username.Equals(username) && stud.Password.Equals(password))
                    {
                        this.Name = stud.Name;
                        this.Surname = stud.Surname;
                        this.Courses = stud.Courses;
                        break;

                    }
                }

            }

        }
        static string theStudentID = "";
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            List<Student> student = readStudentFile();

            foreach (Student stud in student)
            {
                if (stud.Username.Equals(username) && stud.Password.Equals(password))
                {
                    theStudentID = stud.studentID; 
                    return true;
                }
            }
            return false;
        }

        public List<Student> readStudentFile()
        {
            List<Student> student = new List<Student>();
            StreamReader input = new StreamReader("StudentFile.txt");
            string line;

            while ((line = input.ReadLine()) != null)
            {
                string[] entries = line.Split(',');
                Student s = new Student(entries[0], entries[1], entries[2], entries[3], entries[4], entries[5]);

                for (int i = 6; i < entries.Length; i++)
                {
                    s.courses.Add(entries[i]);
                }

                student.Add(s);
            }
            input.Close();
            return student;
        }

        public void showListOfCourses()
        {
            List<Student> student = readStudentFile();

            foreach (Student stud in student){

                if (stud.studentID.Equals(theStudentID) == true)
                {
                    foreach (string i in stud.Courses)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }



    }
}
