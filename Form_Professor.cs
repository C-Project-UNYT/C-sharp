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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_HighestScore_Click(object sender, EventArgs e)
        {

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

      

        private void panel_Output_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Grades_Click(object sender, EventArgs e)
        {
          
        }

        private void button_Students_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (comboBox_Course.SelectedIndex != -1)
            {
                List<Student> students = Professor.getRecentProfessor().getStudents();

                foreach (Student student in students)
                    richTextBox1.AppendText(student.Name + " " + student.Surname + "\n");
            }
            else
                MessageBox.Show("You have not selected a course!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Form_Professor_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome Professor {Professor.getRecentProfessor().Name}";

            foreach (string course in Professor.getRecentProfessor().Courses)
                comboBox_Course.Items.Add(course);
        }

    
     
    }
}
