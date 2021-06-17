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
        public Form_Admin2()
        {
            InitializeComponent();
        }

        public Form_Admin2(int index)
        {
            InitializeComponent();
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
                label5.Hide();
                label6.Hide();
                textBox5.Hide();
                textBox6.Hide();
            }
            
        }

        public void addProfessor()
        {

        }
        public void addStudent()
        {

        }
        public void addCourse()
        {

        }

    }
}