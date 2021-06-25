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
        static string theStudentFullName = "";
        static string path1 = Path.Combine(Directory.GetCurrentDirectory());
        static string[] path = path1.Split("bin");

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
            this.studentID = studentID;
            this.major = major;
            this.courses = courses;
        }

        public Student(string name, string surname, string username, string password, string studentID, string major) : base(name, surname, username, password)
        {
            this.studentID = studentID;
            this.major = major;
        }

        public Student(string username, string password)
        {
            if (isUsernameAndPasswordValid(username, password))
            {
                Username = username;
                Password = password;

                foreach (Student stud in readStudentFile())
                {
                    if (stud.Username.Equals(username) && stud.Password.Equals(password))
                    {
                        Name = stud.Name;
                        Surname = stud.Surname;
                        studentID = stud.studentID;
                        major = stud.major;
                        courses = stud.courses;
                        break;
                    }
                }
            }
        }

        // Method to check the username and password
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            List<Student> student = readStudentFile();

            foreach (Student stud in student)
            {
                if (stud.Username.Equals(username) && stud.Password.Equals(password))
                {
                    theStudentID = stud.studentID;
                    theStudentFullName = stud.Name + " " + stud.Surname;
                    return true;
                }
            }
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        // Method to read the Student File
        public List<Student> readStudentFile()
        {
            List<Student> student = new List<Student>();
            StreamReader input = new StreamReader(path[0] + "StudentFile.txt");

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

        // Method to print the full name of the student
        public string showStudentName()
        {
            return theStudentFullName;
        }

        // Method to show all the university courses
        public List<string> showAllCourses()
        {
            Courses course = new Courses();
            List<Courses> theCourses = course.readCoursesFromFile();
            List<string> allCourses = new List<string>();

            foreach (Courses c in theCourses)
            {
                allCourses.Add(c.Subject);
            }
            return allCourses;
        }

        // Method to show the grades for the student
        public List<string> showCoursesGrade()
        {
            Grades grade = new Grades();

            List<Grades> theStudentGrades = grade.readGradesFile();
            List<string> yourGrades = new List<string>();

            foreach (Grades grades in theStudentGrades)
            {
                try
                {
                    if (theStudentID.Equals(grades.StudentID))
                    {
                        yourGrades.Add(grades.Subject + " " + grades.Grade);
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    yourGrades.Add(e.Message);
                }
            }

            return yourGrades;
        }

        // Write the course in the file
        public void writeANewCourse(string text)
        {
            List<Student> student = readStudentFile();

            using (StreamWriter writer1 = new StreamWriter(path[0] + "StudentFile.txt"))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," + stud.Major);

                    if (stud.studentID.Equals(theStudentID) == true)
                    {
                        stud.courses.Add(text);
                    }

                    foreach (String cour in stud.Courses)
                    {
                        writer1.Write("," + cour);
                    }
                    writer1.WriteLine();
                }
                writer1.Flush();
                writer1.Close();
            }
        }

        // Drop a course
        public void exitANewCourse(string text)
        {
            List<Student> student = readStudentFile();

            using (StreamWriter writer1 = new StreamWriter(path[0] + "StudentFile.txt", false))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," +
                        stud.Major);

                    if (stud.studentID.Equals(theStudentID) == true)
                    {
                        stud.Courses.Remove(text);
                    }

                    foreach (String cour in stud.Courses)
                    {
                        writer1.Write("," + cour);
                    }
                    writer1.WriteLine();
                }
                writer1.Flush();
                writer1.Close();
            }
        }

        // Method to show all courses, except the courses that he is in
        public List<string> allCoursesExcludingStudentCourses()
        {
            Courses course = new Courses();
            List<Student> students = readStudentFile();
            List<Courses> courses = course.readCoursesFromFile();
            List<string> availableCourses = new List<string>();
            int token = 0;

            foreach (Courses c in courses)
            {
                foreach (Student s in students)
                {
                    if (s.studentID.Equals(theStudentID))
                    {
                        token = 0;
                        foreach (string a in s.Courses)
                        {
                            if (a.Equals(c.Subject))
                            {
                                token++;
                            }
                        }
                        if (token == 0)
                            availableCourses.Add(c.Subject);
                    }
                }
            }
            return availableCourses;
        }

        // Method to check all student courses
        public List<string> studentCourses()
        {
            Courses course = new Courses();
            List<Student> students = readStudentFile();
            List<Courses> courses = course.readCoursesFromFile();
            List<string> myCourses = new List<string>();

            foreach (Student s in students)
            {
                if (s.studentID.Equals(theStudentID))
                {
                    foreach (string a in s.Courses)
                    {
                        myCourses.Add(a);
                    }
                }
            }
            return myCourses;
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
                this.StudentID + "," + this.Major;
                for (int j = 0; j < this.Courses.Count; j++)
                {
                    result += "," + this.Courses[j];
                }
                return result;
            }
        }
    }
}
