﻿using System;
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
    public partial class Form_Splash : Form
    {
        public Form_Splash()
        {
           
                InitializeComponent();
           
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(10);

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Form_Login login = new Form_Login();
                this.Hide();
                login.Show();
            }
        }

        private void Form_Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();     
        }
    }
}
