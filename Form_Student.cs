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

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            Student stud = new Student();
            //
            List<string> studentCourses = stud.showListOfCourses();

            if (studentCourses.Count != 0)
            {
                richTextBox1.AppendText("The courses that you are taking are: " + Environment.NewLine);

                foreach (string courses in studentCourses)
                {
                    richTextBox1.AppendText(courses + Environment.NewLine);
                }
            }
            else
                richTextBox1.AppendText("You are not registered in any course" + Environment.NewLine);

        }
    }
}
