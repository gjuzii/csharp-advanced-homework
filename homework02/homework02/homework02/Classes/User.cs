using homework02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework02.Classes
{
    public abstract class User : IUser
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public abstract void PrintUser();
        
    }
}
