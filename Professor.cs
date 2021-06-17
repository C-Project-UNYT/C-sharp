 using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Professor : Person, Login
    {
        // data fields
        private List<string> courses = new List<string>();
        private string activeCourse;

        //attributes
        public List<string> Courses { get => courses; set => courses = value; }
        public string ActiveCourse { get => activeCourse; set => activeCourse = value; }

        //constructors
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

        // method to read data from Professor File
        public List<Professor> readProfessorFile()
        {
            List<Professor> list = new List<Professor>();
            StreamReader reader = new StreamReader(@"C:\Users\sarah\Desktop\C-sharp\ProfessorFile.txt");

            while (!reader.EndOfStream) {

                var line = reader.ReadLine();
                var data = line.Split(",");


                Professor prof = new Professor(data[0], data[1], data[2], data[3]);
               
                for (int i = 4; i < data.Length; i++)
                    prof.Courses.Add(data[i]);

                list.Add(prof);       
            }

            reader.Close();

            return list;
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

    }
}
