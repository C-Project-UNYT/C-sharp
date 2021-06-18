using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    public class Courses
    {
        string subject;
        string time;
        string credits;
        string professor;

        public string Subject
        {
            set
            {
                subject = value;
            }
            get
            {
                return subject;
            }
        }
        public string Time
        {
            set
            {
                time = value;
            }
            get
            {
                return time;
            }
        }
        public string Credits
        {
            set
            {
                credits = value;
            }
            get
            {
                return credits;
            }
        }
        public string Professor
        {
            set
            {
                professor = value;
            }
            get
            {
                return professor;
            }
        }

        public Courses()
        {

        }
        public Courses(string subject, string time, string credits, string professor)
        {
            this.Subject = subject;
            this.Time = time;
            this.Credits = credits;
            this.Professor = professor;
        }
        public List<Courses> readCoursesFromFile()
        {
            List<Courses> list = new List<Courses>();

            var path1 = Path.GetFullPath(@"CoursesFile.txt");

            StreamReader reader = new StreamReader(path1);

            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var data = line.Split(",");

                Courses course = new Courses(data[0], data[1], data[2], data[3]);

                list.Add(course);
            }

            reader.Close();

            return list;
        }
    }
}
