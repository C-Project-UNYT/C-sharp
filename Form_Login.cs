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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPass.Checked)
                textBox_Pass.UseSystemPasswordChar = false;
            else
                textBox_Pass.UseSystemPasswordChar = true;
        }

        private void button_Continue_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Role.SelectedIndex == 0)
            {
                Admin admin = new Admin();
                if (admin.isUsernameAndPasswordValid(textBox_Username.Text, textBox_Pass.Text))
                {
                    Form_Admin formAdmin = new Form_Admin();
                    this.Hide();
                    formAdmin.Show();
                }
            }
            else if (comboBox_Role.SelectedIndex == 1)
            {
                 Professor prof = new Professor(textBox_Username.Text, textBox_Pass.Text);
                try
                {
                    if (prof.isUsernameAndPasswordValid(textBox_Username.Text, textBox_Pass.Text))
                    {
                        Form_Professor formProf = new Form_Professor();
                        this.Hide();
                        formProf.Show();
                    }
                }
                catch (InvalidLoginInfoException ex)
                {
                    MessageBox.Show("You have not entered the correct username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (comboBox_Role.SelectedIndex == 2)
            {


            }
            else
                MessageBox.Show("You have not selected a role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        


        private void comboBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    
}