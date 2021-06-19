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
    public partial class Form_Professor : Form
    {
        public Form_Professor()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLowestScore_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                richTextBox1.Text = $"The student with the lowest score is {Professor.getRecentProfessor().getLowestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().GetMinGrade()}.";
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void button_HighestScore_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                richTextBox1.Text = $"The student with the highest score is {Professor.getRecentProfessor().getHighestScoringStudent()}.\nThey have a score of {Professor.getRecentProfessor().GetMaxGrade()}.";
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }

        private void comboBox_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Professor.getRecentProfessor().ActiveCourse = (string) comboBox_Course.SelectedItem;
        }


        private void button_Grades_Click(object sender, EventArgs e)
        {
            if (comboBox_Course.SelectedIndex != -1) {
                Form_Professor_AddGrades form = new Form_Professor_AddGrades();
            this.Hide();
            form.Show();
        }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_Students_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There are no students enrolled for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form_Professor_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome Professor {Professor.getRecentProfessor().Name} !";

            foreach (string course in Professor.getRecentProfessor().Courses)
                comboBox_Course.Items.Add(course);
        }

        private void button_Average_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                Double average = Professor.getRecentProfessor().GetAverage();
                List<Student> students = Professor.getRecentProfessor().getStudents();

                if (average == 0)
                {
                    MessageBox.Show("There are no grades in the system for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (students.Count == 0)
                {
                    MessageBox.Show("There are no students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                richTextBox1.AppendText($"The course score average is {average:F1}.");
             
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_PassingStudents_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getPassingStudents();

                if (students.Count == 0)
                {
                    MessageBox.Show("There are no passing students for this course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
