using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    public class Admin : Login
    {
        private static string username = "admin";
        private static string password = "admin123";

        public List<Professor> professorList = new List<Professor>();
        public List<Student> studentList = new List<Student>();
        public List<Courses> coursesList = new List<Courses>();

        static string path1 = Path.Combine(Directory.GetCurrentDirectory());
        static string[] path = path1.Split("bin");

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

        //check the validity of the username and the password of the admin
        public bool isUsernameAndPasswordValid(string username, string password)
        {
            if (username.Equals(this.getUsername()) && password.Equals(this.getPassword()))
                return true;
            throw new InvalidLoginInfoException("Username and Password do not match!");
        }

        public void addProfessor(Professor prof)
        {
            professorList.Add(prof);
        }
        public void removeProfessor(Professor prof)
        {
            string name = prof.Name;
            string surname = prof.Surname;
            for (int i = 0; i < professorList.Count; i++)
            {
                if (prof.Equals(professorList.ElementAt(i)))
                {
                    professorList.RemoveAt(i);
                }
            }
            for (int j = 0; j < coursesList.Count; j++)
            {
                if (coursesList.ElementAt(j).Professor.Equals(name + " " + surname))
                {
                    for (int k = 0; k < studentList.Count; k++)
                    {
                        if (studentList.ElementAt(k).Courses.Count > 0)
                        {
                            for (int x = 0; x < studentList.ElementAt(k).Courses.Count; x++)
                            {
                                if (coursesList.ElementAt(j).Subject.Equals(studentList.ElementAt(k).Courses[x]))
                                    studentList.ElementAt(k).Courses.RemoveAt(x);
                            }
                        }
                    }
                    coursesList.RemoveAt(j);
                    j--;
                }
            }
        }
        public void addStudent(Student stud)
        {
            studentList.Add(stud);
        }
        public void removeStudent(Student stud)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (stud.Equals(studentList.ElementAt(i)))
                {
                    studentList.RemoveAt(i);
                    break;
                }
            }
        }
        public void addCourse(Courses course)
        {
            coursesList.Add(course);

            for (int i = 0; i < professorList.Count; i++)
            {
                if (course.Professor.Equals(professorList.ElementAt(i).Name + " " + professorList.ElementAt(i).Surname))
                    professorList.ElementAt(i).Courses.Add(course.Subject);
            }
        }
        public void removeCourse(Courses course)
        {
            for (int i = 0; i < coursesList.Count; i++)
            {
                if (course.Equals(coursesList.ElementAt(i)))
                {
                    for (int j = 0; j < professorList.Count; j++)
                    {
                        if (course.Professor.Equals(professorList.ElementAt(j).Name + " " + professorList.ElementAt(j).Name))
                            professorList.ElementAt(j).Courses.Remove(course.Subject);
                    }
                    for (int k = 0; k < studentList.Count; k++)
                    {
                        if (studentList.ElementAt(k).Courses.Count > 0)
                        {
                            for (int x = 0; x < studentList.ElementAt(k).Courses.Count; x++)
                            {
                                if (course.Subject.Equals(studentList.ElementAt(k).Courses[x]))
                                    studentList.ElementAt(k).Courses.RemoveAt(x);
                            }
                        }
                    }
                    coursesList.RemoveAt(i);
                }
            }
        }

        private void readFiles()
        {
            string ProffesorInput, StudentInput, CoursesInput;

            StreamReader ProfessorFile = new StreamReader(path[0] + "ProfessorFile.txt");

            while ((ProffesorInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = ProffesorInput.Split(',');

                Professor prof = new Professor(data[0], data[1], data[2], data[3]);

                if (data.Length > 4)
                {
                    for (int i = 4; i < data.Length; i++)
                        prof.Courses.Add(data[i]);
                }

                professorList.Add(prof);
            }

            StreamReader StudentFile = new StreamReader(path[0] + "StudentFile.txt");
            while ((StudentInput = StudentFile.ReadLine()) != null)
            {
                string[] data = StudentInput.Split(',');

                Student stud = new Student(data[0], data[1], data[2], data[3], data[4], data[5]);

                if (data.Length > 6)
                {
                    for (int i = 6; i < data.Length; i++)
                        stud.Courses.Add(data[i]);
                }
                studentList.Add(stud);
            }

            StreamReader CoursesFile = new StreamReader(path[0] + "CoursesFile.txt");
            while ((CoursesInput = CoursesFile.ReadLine()) != null)
            {
                string[] data = CoursesInput.Split(',');
                Courses course = new Courses(data[0], data[1], data[2], data[3]);
                coursesList.Add(course);
            }

            ProfessorFile.Close();
            StudentFile.Close();
            CoursesFile.Close();

        }
        public void writeFiles()
        {
            using (StreamWriter ProfessorFile = new StreamWriter(path[0] + "ProfessorFile.txt", false))
            {

                for (int i = 0; i < professorList.Count; i++)
                {
                    string profData = professorList.ElementAt(i).ToString();
                    ProfessorFile.WriteLine(profData);
                }
            }

            using (StreamWriter StudentFile = new StreamWriter(path[0] + "StudentFile.txt", false))
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    StudentFile.WriteLine(studentList.ElementAt(i).toString());
                }
            }

            using (StreamWriter CoursesFile = new StreamWriter(path[0] + "CoursesFile.txt", false))
            {
                for (int i = 0; i < coursesList.Count; i++)
                {
                    CoursesFile.WriteLine(coursesList.ElementAt(i).toString());
                }
            }
        }
    }
}