using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{

   public abstract class Person
    {
        private string name;
        private string surname;
        private string username;
        private string password;

        protected Person(string name, string surname, string username, string password)
        {
            this.Name = name;
            this.Surname = surname;
            this.Username = username;
            this.Password = password;
        }

        public Person() { }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
