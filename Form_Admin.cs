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
        Admin admin;
        public Form_Admin()
        {
            InitializeComponent();
            admin = new Admin();
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
            this.Close();
            login.Show();
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if(checkedListBox_Admin.SelectedItem.Equals("Add professor"))
            {
                Form_Admin2 child1 = new Form_Admin2(1);
                //child1.MdiParent = this;
                
                child1.Show();

            }
            if (checkedListBox_Admin.SelectedItem.Equals("Add student"))
            {
                Form_Admin2 child1 = new Form_Admin2(2);
                //child1.MdiParent = this;

                child1.Show();
                
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Add course"))
            {
                Form_Admin2 child1 = new Form_Admin2(3);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove professor"))
            {
                Form_Admin2 child1 = new Form_Admin2(4);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove student"))
            {
                Form_Admin2 child1 = new Form_Admin2(5);
                //child1.MdiParent = this;

                child1.Show();
            }
            if (checkedListBox_Admin.SelectedItem.Equals("Remove course"))
            {
                Form_Admin2 child1 = new Form_Admin2(6);
                //child1.MdiParent = this;

                child1.Show();
            }
        }
    }
}
