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
    public partial class Form_Welcome : Form
    {
        public Form_Welcome()
        {
            InitializeComponent();
        }

        private void Form_Welcome_Load(object sender, EventArgs e)
        {

        }

        private void Form_Welcome_Load_1(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                MdiClient ctlMDI;
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackColor = Color.DarkBlue;
                    menuStrip1.Enabled = true;
                }
                catch (InvalidCastException ex)
                { }
            }
        }
    

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login child = new Form_Login();
            child.MdiParent = this;
            child.Show();
            child.BringToFront();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
