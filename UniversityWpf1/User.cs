using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityWpf1
{
    internal class User
    {
        public string Userame { get; set; }
        public string Password { get; set; }



        public User(string u, string p)
        {
            Userame = u;
            Password = p;
        }
    }
}
