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

        public bool isUsernameAndPasswordValid(string username, string password)
        {
            return username.Equals(this.getUsername()) && password.Equals(this.getPassword());
        }

        public void addProfessor(Professor prof)
        {
            professorList.Add(prof);
        }
        public void removeProfessor(Professor prof)
        {
            for (int i = 0; i < professorList.Count; i++)
            {
                if (prof.Equals(professorList.ElementAt(i)))
                {
                    for (int j = 0; j < coursesList.Count; j++)
                    {
                        if (coursesList.ElementAt(j).Professor.Equals(professorList.ElementAt(i).Name + " " + professorList.ElementAt(i).Surname))
                            coursesList.RemoveAt(j);
                    }
                    professorList.RemoveAt(i);
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
                }
            }
        }
        public void addCourse(Courses course)
        {
            coursesList.Add(course);

            for(int i = 0; i < professorList.Count; i++)
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
                    coursesList.RemoveAt(i);
                }
            }
        }

        private void readFiles()
        {
            string ProffesorInput, StudentInput, CoursesInput;
            var path1 = Path.GetFullPath(@"ProfessorFile.txt");
            var path2 = Path.GetFullPath(@"StudentFile.txt");
            var path3 = Path.GetFullPath(@"CoursesFile.txt");

            StreamReader ProfessorFile = new StreamReader(path1);

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

            StreamReader StudentFile = new StreamReader(path2);
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

            StreamReader CoursesFile = new StreamReader(path3);
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
            var path1 = Path.GetFullPath(@"ProfessorFile.txt");
            var path2 = Path.GetFullPath(@"StudentFile.txt");
            var path3 = Path.GetFullPath(@"CoursesFile.txt");

            StreamWriter ProfessorFile = new StreamWriter(path1, false);

            for (int i = 0; i < professorList.Count; i++)
            {
                ProfessorFile.WriteLine(professorList.ElementAt(i).toString());
            }
            ProfessorFile.WriteLine("Prova 123");

            StreamWriter StudentFile = new StreamWriter(path2, false);
            for (int i = 0; i < studentList.Count; i++)
            {
                StudentFile.WriteLine(studentList.ElementAt(i).toString());
            }


            StreamWriter CoursesFile = new StreamWriter(path3, false);
            for (int i = 0; i < coursesList.Count; i++)
            {
                StudentFile.WriteLine(coursesList.ElementAt(i).toString());
            }

            ProfessorFile.Close();
            StudentFile.Close();
            CoursesFile.Close();
        }
    }
}