using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public bool usernameValid(string username)
        {
            return username.Equals(this.getUsername());
        }

        public bool passwordValid(string password)
        {
            return password.Equals(this.getPassword());
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
            StreamReader ProfessorFile = new StreamReader(@"C:\Users\user\Documents\GitHub\C-sharp\ProfessorFile.txt");
            string ProffesorInput, StudentInput, CoursesInput;
            while ((ProffesorInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = ProffesorInput.Split(',');

            }


            StreamReader StudentFile = new StreamReader(@"C:\Users\user\Documents\GitHub\C-sharp\StudentFile.txt");
            while ((StudentInput = ProfessorFile.ReadLine()) != null)
            {
                string[] data = StudentInput.Split(',');

            }

            StreamReader CoursesFile = new StreamReader(@"C:\Users\user\Documents\GitHub\C-sharp\CoursesFile.txt");
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