using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Courses
    {
        string subject;
        string time;
        int credits;
        string professor;
        int noOfStudents;

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
        public int Credits
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
        public int NoOfStudents
        {
            set
            {
                noOfStudents = value;
            }
            get
            {
                return noOfStudents;
            }
        }
     
        public Courses(string subject, string time,int credits, string professor, int noOfStudents)
        {
            this.Subject = subject;
            this.Time = time;
            this.Credits = credits;
            this.Professor = professor;
            this.NoOfStudents = noOfStudents;
        }
        public List<Courses> getInfoFromFile()
        {
            List<Courses> list = new List<Courses>();
            var path1 = Path.Combine(Directory.GetCurrentDirectory(), "\\CoursesFile.txt");
            StreamReader reader = new StreamReader(path1);

            while (!reader.EndOfStream)
            {

                var line = reader.ReadLine();
                var data = line.Split(",");


                Courses course = new Courses(data[0], data[1], credits, data[3],noOfStudents);

                for (int i = 5; i < data.Length; i++)
                    course.Add(data[i]);

                list.Add(course);
            }
            reader.Close();

            return list;
        }
        private void Add(string v)
        {
            throw new NotImplementedException();
        }
    }
}
