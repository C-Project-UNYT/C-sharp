using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form_Student : Form
    {
        public Form_Student()
        {
            InitializeComponent();
            Student stud = new Student();
            label1.Text = stud.showStudentName();
        }

        private void Form_Student_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Student_Enroll form = new Form_Student_Enroll();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Student_Drop form = new Form_Student_Drop();
            this.Hide();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Student stud = new Student();
            
            List<string> studentCourse = stud.studentCourses();

            if (studentCourse.Count != 0)
            {
                richTextBox1.AppendText("The courses that you are taking are: " + Environment.NewLine);

                foreach (string courses in studentCourse)
                {
                    richTextBox1.AppendText(courses + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You are not registered in any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Student stud = new Student();
            List<string> grades = stud.showCoursesGrade();

            if (grades.Count != 0)
            {
                richTextBox1.AppendText("The grades of your courses are: " + Environment.NewLine);

                foreach (string grade in grades)
                {
                    richTextBox1.AppendText(grade + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("You do not have any grade in the system!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Student stud = new Student();
            List<string> allCourses = stud.showAllCourses();

            if (allCourses.Count != 0)
            {
                richTextBox1.AppendText("The courses in the university are: " + Environment.NewLine);

                foreach (string s in allCourses)
                {
                    richTextBox1.AppendText(s + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The university does not have any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Student stud = new Student();
            List<string> allCourses = stud.showAllCredits();

            if (allCourses.Count != 0)
            {
                richTextBox1.AppendText("Credits of All the Courses are: " + Environment.NewLine);

                foreach (string s in allCourses)
                {
                    richTextBox1.AppendText(s + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The university does not have any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Student stud = new Student();
            List<string> myCoursesCredits = stud.showMyCredits();

            if (myCoursesCredits.Count != 0)
            {
                richTextBox1.AppendText("Credits of My Courses are: " + Environment.NewLine);

                foreach (string s in myCoursesCredits)
                {
                    richTextBox1.AppendText(s + Environment.NewLine);
                }
            }
            else
                MessageBox.Show("The student is not enrolled in any course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Student stud = new Student();
          
            richTextBox1.AppendText(stud.GPA() + Environment.NewLine);
         
        }
    }
}
