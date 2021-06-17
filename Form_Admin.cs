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
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }

        private void checkedListBox_Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choiceIndex = checkedListBox_Admin.SelectedIndex;
            int count = checkedListBox_Admin.Items.Count;

            for (var i = 0; i < count; i++)
            {
                if (choiceIndex != i)
                    checkedListBox_Admin.SetItemChecked(i, false);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.Show();
        }
    }
}
