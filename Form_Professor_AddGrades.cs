﻿using System;
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
            string[] data = textBox_Input.Text.Split("\n");

            try
            {
                Professor.getRecentProfessor().AddGrades(data);
            }

            catch(InvalidInputException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Grades entered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void textBox_Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
