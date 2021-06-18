using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class Form_Professor_AddGrades : Form
    {
        public Form_Professor_AddGrades()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Professor prof = new Form_Professor();
            this.Hide();
            prof.Show();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
                var path = Path.GetFullPath(@"GradesFile.txt");
  
                string[] data = textBox_Input.Text.Split("\n");

            using(StreamWriter writer = new StreamWriter(path,true))
            {
                foreach(string grade in data)
                {
                    writer.WriteLine(Professor.getRecentProfessor().ActiveCourse + ","+ grade);
                }

                writer.Close();
            }

 
            MessageBox.Show("Grades entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}
