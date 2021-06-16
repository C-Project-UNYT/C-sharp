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
    public partial class Form_Professor : Form
    {
        public Form_Professor()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_HighestScore_Click(object sender, EventArgs e)
        {

        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }
    }
}
