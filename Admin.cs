using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Admin : Login
    {
        private static string username = "admin";
        private static string password = "admin123";

        List<Professor> proffessorList = new List<Professor>();
        List<Student> studentList = new List<Student>();
        List<Courses> coursesList = new List<Courses>();

        public Admin()
        {
            //   this.readFiles();
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
            proffessorList.Add(prof);
        }
        public void removeProfessor(Professor prof)
        {
            if (proffessorList.Count > 0)
            {
                for (int i = 0; i < proffessorList.Count; i++)
                {
                    if (prof.Equals(proffessorList.ElementAt(i)))
                    {
                        proffessorList.RemoveAt(i);
                    }
                }
            }
        }
        public void addStudent(Student stud)
        {
            studentList.Add(stud);
        }
        public void removeStudent(Student stud)
        {
            if (studentList.Count > 0)
            {
                for (int i = 0; i < proffessorList.Count; i++)
                {
                    if (stud.Equals(studentList.ElementAt(i)))
                    {
                        studentList.RemoveAt(i);
                    }
                }
            }
        }
        public void addCourse(Courses course)
        {
            coursesList.Add(course);
        }
        public void removeCourse(Courses course)
        {
            if (coursesList.Count > 0)
            {
                for (int i = 0; i < proffessorList.Count; i++)
                {
                    if (course.Equals(coursesList.ElementAt(i)))
                    {
                        coursesList.RemoveAt(i);
                    }
                }
            }
        }
       
        private void readFiles()
        {
            string ProffesorInput, StudentInput, CoursesInput;
            var path1 = Path.GetFullPath(@"StudentFile.txt");
            var path2= Path.GetFullPath(@"ProfessorFile.txt");
            var path3 = Path.GetFullPath(@"CoursesFile.txt");

            
            if (path2.ReadToEnd() != "")
            {
                while ((ProffesorInput = path2.ReadLine()) != null)
                {
                    string[] data = ProffesorInput.Split(',');

                    Professor prof = new Professor(data[0], data[1], data[2], data[3]);

                    for (int i = 4; i < data.Length; i++)
                        prof.Courses.Add(data[i]);

                    proffessorList.Add(prof);
                }
            }
           

            Assembly asm1 = Assembly.GetExecutingAssembly();
            StreamReader StudentFile = new StreamReader(asm1.GetManifestResourceStream(path1));
            if (StudentFile.ReadToEnd() != "")
            {
                while ((StudentInput = StudentFile.ReadLine()) != null)
                {
                    string[] data = StudentInput.Split(',');

                    Student stud = new Student(data[0], data[1], data[2], data[3], data[4], data[5]);

                    for (int i = 6; i < data.Length; i++)
                        stud.Courses.Add(data[i]);

                    studentList.Add(stud);
                }
            }

            Assembly asm2 = Assembly.GetExecutingAssembly();
            StreamReader CoursesFile = new StreamReader(asm2.GetManifestResourceStream(path3));
            if (CoursesFile.ReadToEnd() != "")
            {
                while ((CoursesInput = CoursesFile.ReadLine()) != null)
                {
                    string[] data = CoursesInput.Split(',');
                    int credits = Int32.Parse(data[2]);
                    int noOfStudents = Int32.Parse(data[4]);
                    Courses course = new Courses(data[0], data[1], credits, data[3], noOfStudents);
                    coursesList.Add(course);
                }
            }

            ProfessorFile.Close();
            StudentFile.Close();
            CoursesFile.Close();

        }
        public void writeFiles()
        {

        }
    }


}