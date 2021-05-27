using homework02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework02.Classes
{
    public class Student : User, IStudent

    {
        public int Grade { get; set; }

        public override void PrintUser()
        {
            Console.WriteLine($"id - {id}, name - {Name}, username - {Username}, grade - {Grade}");
        }
    }
}
