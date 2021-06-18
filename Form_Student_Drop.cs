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
    public partial class Form_Student_Drop : Form
    {
        public Form_Student_Drop()
        {
            InitializeComponent();
            Student stud = new Student();
            foreach (string s in stud.studentCourses())
            {
                comboBox1.Items.Add(s);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Student student = new Form_Student();
            this.Hide();
            student.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();

            if (comboBox1.Text.Length == 0)
            {
                MessageBox.Show("Error! You need to select a course." + MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("The course is dropped successfully." + MessageBoxButtons.OK);
                stud.writeANewCourse(comboBox1.Text);
            }
        }
    }
}
