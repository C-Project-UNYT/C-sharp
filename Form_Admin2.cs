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
    public partial class Form_Admin2 : Form
    {
        Admin admin;
        int index;

        public Form_Admin2(int index, ref Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.index = index;

            if(index == 1)
            {
                label5.Hide();
                label6.Hide();
                textBox5.Hide();
                textBox6.Hide();
                label1.Text = "Name: ";
                label2.Text = "Surname: ";
                label3.Text = "Username: ";
                label4.Text = "Password: ";
                //textBox1.Text = admin.proffessorList.ElementAt(2).Name;
            }
            if (index == 2)
            {
                label1.Text = "Name: ";
                label2.Text = "Surname: ";
                label3.Text = "Username: ";
                label4.Text = "Password: ";
                label5.Text = "Student ID: ";
                label6.Text = "Major: ";
            }
            if (index == 3)
            {
                label1.Text = "Subject: ";
                label2.Text = "Time: ";
                label3.Text = "Credits: ";
                label4.Text = " Professor: ";
                label5.Hide();
                label6.Hide();
                textBox5.Hide();
                textBox6.Hide();
            }
            
        }

        public void addProfessor()
        {
            Professor prof = new Professor(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            admin.addProfessor(prof);
        }
        public void addStudent()
        {
            Student stud = new Student(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            admin.addStudent(stud);
        }
        public void addCourse()
        {
            int credits = Int32.Parse(textBox3.Text);
            Courses course = new Courses(textBox1.Text, textBox2.Text, credits, textBox4.Text);
            admin.addCourse(course);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (index == 1)
                this.addProfessor();
            if (index == 2)
                this.addStudent();
            if (index == 3)
                this.addCourse();
            MessageBox.Show("Complete!");
            this.Close();
        }
    }
}