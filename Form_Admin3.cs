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
    public partial class Form_Admin3 : Form
    {
        int index;
        Admin admin;
        public Form_Admin3(int index, ref Admin admin)
        {
            InitializeComponent();
            this.index = index;
            this.admin = admin;

            if(index == 4)
            {
                for(int i = 0; i < admin.professorList.Count; i++)
                {
                    comboBox1.Items.Add(admin.professorList.ElementAt(i).Name + " " + admin.professorList.ElementAt(i).Surname);
                }
            }
            
            if(index == 5)
            {
                for(int i = 0; i < admin.studentList.Count; i++)
                {
                    comboBox1.Items.Add(admin.studentList.ElementAt(i).Name + " " + admin.studentList.ElementAt(i).Surname);
                }
            }

            if(index == 6)
            {
                for(int i = 0; i < admin.coursesList.Count; i++)
                {
                    comboBox1.Items.Add(admin.coursesList.ElementAt(i).Subject + " " + admin.coursesList.ElementAt(i).Professor);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(index == 4)
            {
                admin.removeProfessor(admin.professorList.ElementAt(comboBox1.SelectedIndex));
            }
            if(index == 5)
            {
                admin.removeStudent(admin.studentList.ElementAt(comboBox1.SelectedIndex));
            }
            if(index == 6)
            {
                admin.removeCourse(admin.coursesList.ElementAt(comboBox1.SelectedIndex));
            }
            MessageBox.Show("Complete!");
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
