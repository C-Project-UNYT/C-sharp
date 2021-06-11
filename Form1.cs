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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    }

    interface Login //take a look...
    {
        bool usernameValid();
        bool passwordValid();
    }

    abstract class Person
    {
        private string name;
        private string surname;

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }

    class Admin : Login
    {
        public bool usernameValid()
        {
            return false;
        }

        public bool passwordValid()
        {
            return false;
        }
    }
}