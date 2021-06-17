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
                for(int i = 0; i < admin.proffessorList.Count; i++)
                {
                    comboBox1.Items.Add(admin.proffessorList.ElementAt(i).Name + " " + admin.proffessorList.ElementAt(i).Surname);
                }
            }
            
            if(index == 5)
            {

            }

            if(index == 6)
            {

            }
        }
    }
}
