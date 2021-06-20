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
    public partial class Form_Student_Enroll : Form
    {
        public Form_Student_Enroll()
        {
            InitializeComponent();

            Student stud = new Student();
            foreach (string s in stud.allCoursesExcludingStudentCourses())
            {
                comboBox1.Items.Add(s);
            }
                
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Student student = new Form_Student();
            this.Hide();
            student.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();

            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("You need to select a course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                stud.writeANewCourse(comboBox1.Text);
                MessageBox.Show("The course is added successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
