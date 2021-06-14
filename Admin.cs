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

        public void addProfessor()
        {

        }
        public void removeProfessor()
        {

        }
        public void addStudent()
        {

        }
        public void removeStudent()
        {

        }
        public void addCourse()
        {

        }
        public void removeCourse()
        {

        }

        private void readFiles()
        {
            string ProffesorInput, StudentInput, CoursesInput;

            Assembly asm = Assembly.GetExecutingAssembly();
            StreamReader ProfessorFile = new StreamReader(asm.GetManifestResourceStream("PROJECT.Files.ProfessorFile.txt"));
            while ((ProffesorInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = ProffesorInput.Split(',');

            }

            Assembly asm1 = Assembly.GetExecutingAssembly();
            StreamReader StudentFile = new StreamReader(asm1.GetManifestResourceStream("PROJECT.Files.StudentFile.txt"));
            while ((StudentInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = StudentInput.Split(',');

            }

            Assembly asm2 = Assembly.GetExecutingAssembly();
            StreamReader CoursesFile = new StreamReader(asm2.GetManifestResourceStream("PROJECT.Files.CoursesFile.txt"));
            while ((CoursesInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = CoursesInput.Split(',');
                int credits = Int32.Parse(data[2]);
                int noOfStudents = Int32.Parse(data[4]);
                Courses course = new Courses(data[0], data[1], credits, data[3], noOfStudents);
                coursesList.Add(course);
            }

            ProfessorFile.Close();
            StudentFile.Close();
            CoursesFile.Close();
        }
    }

}