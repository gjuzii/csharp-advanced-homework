using homework02.Classes;
using System;

namespace homework02
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher firstTeacher = new Teacher
            {
                id = 268,
                Name = "Jane",
                Username = "Jane268",
                Password = "JanE",
                Subject = "CSharp"
            };

            Teacher secondTeacher = new Teacher
            {
                id = 306,
                Name = "Bob",
                Username = "Bob306",
                Password = "BoB",
                Subject = "CSharp-Advanced"
            };


            Student firstStudent = new Student
            {
                id = 100,
                Name = "Jessica",
                Username = "Jessica100",
                Password = "JessicA",
                Grade = 5
            };

            Student secondStudent = new Student
            {
                id = 180,
                Name = "Max",
                Username = "Max180",
                Password = "MaX",
                Grade = 3
            };

            firstTeacher.PrintUser();
            secondTeacher.PrintUser();
            firstStudent.PrintUser();
            secondStudent.PrintUser();
        }
    }
}
