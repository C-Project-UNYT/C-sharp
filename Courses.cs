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

        Courses(string subject, string time, int credits, string professorName, string professorSurname, int noOfStudents)
        {
            this.subject = subject;
            this.time = time;
            this.credits = credits;
            this.professor = professor + " " + professorSurname;
            this.noOfStudents = noOfStudents;
        }
    }
}
