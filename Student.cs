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
        static string path = Path.Combine(Directory.GetCurrentDirectory());

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
            List<Student> student = new List<Student>();
       
            StreamReader input = new StreamReader((path + "\\StudentFile.txt"));

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
                foreach (string i in stud.Courses)
                {
                    myCourse.Add(i);
                }
            }
            return myCourse;
        }

        public string showStudentName() {

            List<Student> stud = this.readStudentFile();

            foreach(Student s in stud)
            {
                if (s.studentID.Equals(theStudentID))
                {
                    return (s.Name + " " + s.Surname);
                }
            }
            return null;
        }

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

        public List<string> showCoursesGrade()
        {
            List<string> grades = new List<string>();
            StreamReader input = new StreamReader((path + "\\GradesFile.txt"));
            string line;

            while ((line = input.ReadLine()) != null)
            {
                string[] entries = line.Split(',');

                try
                {
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
                catch (IndexOutOfRangeException e)
                {
                    grades.Add(e.Message);
                }
            }

            input.Close();
            return grades;
        }

        public void writeANewCourse(string text)
        {
            
            List<Student> student = readStudentFile();

            using (StreamWriter writer1 = new StreamWriter(path + "\\StudentFile.txt", false))
            {
                foreach (Student stud in student)
                {
                    writer1.Write(stud.Name + "," + stud.Surname + "," + stud.Username + "," + stud.Password + "," + stud.StudentID + "," +
                        stud.Major);
                   
                   /* if (stud.studentID.Equals(theStudentID) == true)
                    {
                        stud.courses.Add(text);
                    }
                    */
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

        public void exitANewCourse(string text)
        {
            List<Student> student = readStudentFile();

            using (StreamWriter writer1 = new StreamWriter((path + "\\StudentFile.txt"), false))
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
        public List<string> allCoursesExcludingStudentCourses()
        {
            Courses course = new Courses();
            List<Student> students = readStudentFile();
            List<Courses> courses = course.readCoursesFromFile();
            List<string> availableCourses = new List<string>();
            int token = 0;

            foreach(Courses c in courses)
            {
                foreach(Student s in students)
                {
                    if (s.studentID.Equals(theStudentID))
                    {
                        token = 0;
                        foreach(string a in s.Courses)
                        {
                            if (a.Equals(c.Subject))
                            {
                                token++;
                            }
                        }
                        if(token == 0)
                            availableCourses.Add(c.Subject);
                    }
                }
            }
            return availableCourses;
        }

        public List<string> studentCourses()
        {
            Courses course = new Courses();
            List<Student> students = readStudentFile();
            List<Courses> courses = course.readCoursesFromFile();
            List<string> myCourses = new List<string>();

            foreach (Courses c in courses)
            {
                foreach (Student s in students)
                {
                    if (s.studentID.Equals(theStudentID))
                    {
                        foreach (string a in s.Courses)
                        {
                            if (a.Equals(c.Subject))
                            {
                                myCourses.Add(c.Subject);
                            }
                        }
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
