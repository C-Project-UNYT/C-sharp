 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public class Professor : Person, Login
    {
        // data fields
        private List<string> courses = new List<string>();
        private string activeCourse;
        private static List<Professor> loggedProfessors = new List<Professor>();

        // attributes
        public List<string> Courses { get => courses; set => courses = value; }
        public string ActiveCourse { get => activeCourse; set => activeCourse = value; }
        public static List<Professor> LoggedProfessors { get => loggedProfessors; set => loggedProfessors = value; }

        // constructors
        public Professor(string name, string surname, string username, string password) : base(name, surname, username, password)
        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
        }

        public Professor(string username, string password)
        {
                this.Username = username;
                this.Password = password;

                foreach(Professor prof in readProfessorFile())
                {
                    if (prof.Username.Equals(username) && prof.Password.Equals(password))
                    {
                        this.Name = prof.Name;
                        this.Surname = prof.Surname;
                        this.Courses = prof.Courses;
                        break;
                    }
                }

        }

        // method to show passing students

        public List<Student> getPassingStudents()
        {
            List<Student> studentList = new List<Student>();
            List<string> studentIds = new List<string>();

            foreach(Grades grade in getGrades())
            {
                if (grade.Grade > 59)
                    studentIds.Add(grade.StudentID);
            }

            foreach(string Id in studentIds)
            {
                studentList.Add(getStudentFromID(Id));
            }

            return studentList;
        }

        // method to get the name of the lowest scoring student
        public string getLowestScoringStudent()
        {
            string studentID = "";

            string studentName = "";

            foreach (Grades grade in getGrades())
            {
                if (grade.Grade == GetMinGrade())
                {
                    studentID = grade.StudentID;
                    break;
                }
            }

            List<Student> studentList = getStudents();

            foreach (Student stud in studentList)
            {
                if (stud.StudentID.Equals(studentID))
                {
                    studentName = stud.Name + " " + stud.Surname;
                    break;
                }
            }

            return studentName;
        }

        // method to get the name of the highest scoring student
        public string getHighestScoringStudent()
        {
            string studentID = "";

            string studentName ="";

            foreach (Grades grade in getGrades())
            {
                if (Convert.ToDouble(grade.Grade) == GetMaxGrade())
                {
                    studentID = grade.StudentID;
                    break;
                }
            }

            List<Student> studentList = getStudents();

            foreach (Student stud in studentList)
            {
                if (stud.StudentID.Equals(studentID)) 
                { 
                    studentName = stud.Name + " " + stud.Surname;
                    break;
                }
            }

            return studentName;
        }

        // method to get grades of course
        public List<Grades> getGrades()
        {
            List<Grades> gradeList = new List<Grades>();
            Grades grade = new Grades();

            foreach (Grades grades in grade.readGradesFile())
            {
                if (grades.Subject.Equals(ActiveCourse))
                    gradeList.Add(grades);
            }

            return gradeList;
        }


        // method to get all the scores of a professor's course
        public List<Double> getScores()
        {
            List<Double> gradeList = new List<Double>();
            Grades grade = new Grades();

            foreach (Grades grades in grade.readGradesFile())
            {
                if (grades.Subject.Equals(ActiveCourse))
                    gradeList.Add(grades.Grade);
            }

            return gradeList;
        }

        // method to get the minimum grade of a professor's course
        public double GetMinGrade()
        {
            List<Double> gradeList = getScores();

            double min = gradeList.ElementAt(0);
            for(int i=1;i<gradeList.Count;i++)
            {
                if( gradeList.ElementAt(i) < min)
                {
                    min = gradeList.ElementAt(i);
                }
            }

            return min;
        }

        // method to get the maximum grade of a professor's course

        public double GetMaxGrade()
        {
            List<Double> gradeList = getScores();

            double max = gradeList.ElementAt(0);
            for (int i = 1; i < gradeList.Count; i++)
            {
                if (gradeList.ElementAt(i) > max)
                {
                    max = gradeList.ElementAt(i);
                }
            }
            return max;
        }

        // method to get the average grade of a professor's course

        public double GetAverage()
        {
            List<Double> gradeList = getScores();

            double total = 0.0;
            foreach (Double grade in gradeList)
                total += grade;

            return total / gradeList.Count;
        }


        // method to show the students of a professor's course

        public List<Student> getStudents()
        {
            List<Student> students = new List<Student>();
            Student student = new Student();

            foreach(Student stud in student.readStudentFile())
            {
                if (stud.Courses.Contains(ActiveCourse))
                    students.Add(stud);
            }

            return students;
        }


        // method to read data from Professor File
        public List<Professor> readProfessorFile()
        {
           var path = Path.GetFullPath(@"ProfessorFile.txt");

            List<Professor> list = new List<Professor>();

            using (StreamReader reader = new StreamReader(path))
            {

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    var data = line.Split(",");


                    Professor prof = new Professor(data[0], data[1], data[2], data[3]);

                    for (int i = 4; i < data.Length; i++)
                        prof.Courses.Add(data[i]);

                    list.Add(prof);
                }

                reader.Close();
            }
            return list;
        }

        // method to get student object from ID
        public Student getStudentFromID(string Id)
        {
            foreach(Student student in getStudents())
            {
                if (student.StudentID.Equals(Id))
                    return student;
            }

            return null;
        }

        // method to determine if the login info is valid
        public bool isUsernameAndPasswordValid(string username, string password) 
        {
            List<Professor> list = readProfessorFile();

            foreach (Professor prof in list)
            {
                if (prof.Username.Equals(username) && prof.Password.Equals(password))
                    return true;
            }
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        // method to get the most recently logged professor
        public static Professor getRecentProfessor()
        {
            return LoggedProfessors.Last();
        }

        public string toString()
        {
            if (this.Courses == null)
                return this.Name + "," + this.Surname + "," + this.Username + "," + this.Password;
            else
            {
                string result = "";
                result = this.Name + "," + this.Surname + "," + this.Username + "," + this.Password + ",";
                for (int j = 0; j < this.Courses.Count; j++)
                {
                    result += this.Courses[j] + ",";
                }
                return result;
            }
        }
    }
}
