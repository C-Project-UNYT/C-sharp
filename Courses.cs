using System;
using System.Collections.Generic;
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

        public Courses(string subject, string time, int credits, string professor, int noOfStudents)
        {
            this.subject = subject;
            this.time = time;
            this.credits = credits;
            this.professor = professor;
            this.noOfStudents = noOfStudents;
        }
    }
}
