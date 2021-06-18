using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PROJECT
{
    public class Student : Person, Login
    {
        public string major;
        public string studentID;
        public List<string> courses = new List<string>();
        static string theStudentID = "";

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

        public Student()
        {

        }
        public Student(string name, string surname, string username, string password, string studentID, string major, List<String> courses) : base(name, surname, username, password)
        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
            this.studentID = studentID;
            this.major = major;
            this.courses = courses;
        }

        public Student(string name, string surname, string username, string password, string studentID, string major) : base(name, surname, username, password)
        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
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
                        this.studentID = stud.studentID;
                        this.major = stud.major;
                        this.courses = stud.courses;
                        break;
                    }
                }
            }
        }

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
            var path1 = Path.GetFullPath(@"StudentFile.txt");
            List<Student> student = new List<Student>();
            StreamReader input = new StreamReader(path1);

            string line;

            while ((line = input.ReadLine()) != null)
            {
                string[] entries = line.Split(',');
                Student s = new Student(entries[0], entries[1], entries[2], entries[3], entries[4], entries[5]);

                if (entries.Length > 5)
                {
                    for (int i = 6; i < entries.Length; i++)
                    {
                        s.Courses.Add(entries[i]);
                    }
                }
                student.Add(s);
            }
            input.Close();
            return student;
        }

        public List<string> showListOfCourses()
        {
            List<Student> student = readStudentFile();
            List<string> myCourse = new List<string>();

            foreach (Student stud in student)
            {

                if (stud.studentID.Equals(theStudentID) == true)
                {
                    foreach (string i in stud.Courses)
                    {
                        myCourse.Add(i);
                    }
                }
            }
            return myCourse;
        }

        public List<string> showCoursesGrade()
        {

            var path1 = Path.GetFullPath(@"GradesFile.txt");
            List<string> grades = new List<string>();
            StreamReader input = new StreamReader(path1);
            string line;

            while ((line = input.ReadLine()) != null)
            {
                string[] entries = line.Split(',');

                if (theStudentID.Equals(entries[1]))
                {

                    if (entries.Length == 2)
                    {
                        grades.Add(entries[0] + ": " + "Pending...");
                    }
                    else
                        grades.Add(entries[0] + ": " + entries[2]);
                }

            }
            input.Close();
            return grades;
        }

        public void writeANewCourse(string text)
        {
            var path1 = Path.GetFullPath(@"StudentFile.txt");
            var path2 = Path.GetFullPath(@"GradesFile.txt");
            List<Student> student = readStudentFile();
            List<string> myCourse = new List<string>();

            using (StreamWriter writer2 = new StreamWriter(path2, true))
            {



                foreach (Student stud in student)
                {
                    if (stud.studentID.Equals(theStudentID) == true)
                    {
                        stud.courses.Add(text);
                        writer2.Write(text + "," + stud.StudentID);
                    }
                }
                writer2.Close();
            }
            using (StreamWriter writer1 = new StreamWriter(path1))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," +
                        stud.Major);

                    foreach (String cour in Courses)
                    {
                        writer1.Write("," + cour);
                    }
                    writer1.Write("," + text);
                    writer1.WriteLine();
                }
                writer1.Close();
            }
        }

        public Boolean isInTheFile(string text)
        {
            Courses course = new Courses();
            List<Courses> courses = course.readCoursesFromFile();

            foreach (Courses c in courses)
            {
                if (c.Subject.Equals(text))
                {
                    return true;
                }
            }
            return false;

        }
        public int canBeAdded(string text)
        {
            List<Student> student = readStudentFile();

            if (this.isInTheFile(text) == true)
            {
                foreach (Student stud in student)
                {
                    if (stud.StudentID.Equals(theStudentID) == true)
                    {
                        foreach (string i in stud.Courses)
                        {
                            if (i.Equals(text))
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
            else
                return 2;

            return 1;
        }

        public string toString()
        {
            if (this.Courses == null)
                return this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.StudentID + "," + this.Major;
            else
            {
                string result = "";
                result = this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + "," +
                this.StudentID + "," + this.Major + ",";
                for (int j = 0; j < this.Courses.Count; j++)
                {
                    result += this.Courses[j] + ",";
                }
                return result;
            }
        }
    }
}
