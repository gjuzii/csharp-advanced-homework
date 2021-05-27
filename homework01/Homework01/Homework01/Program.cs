using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some words. When your done enter x");
            List<string> words = new List<string>();
            bool notValid = true;

            while (notValid)
            {
                string inputx = Console.ReadLine();
                if (inputx.ToLower() != "x")
                {
                    words.Add(inputx);
                }
                else 
                {
                    notValid = !notValid;
                }

                

            }

            Console.WriteLine("Enter text ");
            string text = Console.ReadLine();
            List<string> textList = text.Split(" ").ToList();
            foreach(var word in words)
            {
                var search = textList.Where(input => input.Contains(word));
                Console.WriteLine($"The word {word} appears {search.Count()} times in your text");
            }
        }
    }
}
