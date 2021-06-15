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
                textBox_Password.UseSystemPasswordChar = false;
            else
                textBox_Password.UseSystemPasswordChar = true;
        }
    }

    
}