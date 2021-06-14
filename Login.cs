using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    interface Login {

        bool usernameValid(string username);
        bool passwordValid(string password);
    }
}
