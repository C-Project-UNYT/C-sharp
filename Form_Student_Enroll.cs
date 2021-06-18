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

            if (stud.canBeAdded(textBox1.Text) == 2)   
                MessageBox.Show("This course does not exist");
            else if (stud.canBeAdded(textBox1.Text) == 0)
                MessageBox.Show("You can not add this course, because you are already in");
            else
            {
                stud.writeANewCourse(textBox1.Text);
                MessageBox.Show("Added");
            }

        }
    }
}
