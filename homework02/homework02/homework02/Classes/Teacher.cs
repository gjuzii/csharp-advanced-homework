using homework02.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace homework02.Classes
{
    public class Teacher : User, ITeacher

    {
        public string Subject { get; set;}

        public override void PrintUser()
        {
            Console.WriteLine($"id - {id}, name - {Name}, username - {Username}, subject - {Subject}");
        }
    }
}
