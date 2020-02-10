using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input your name: ");
            string name = Console.ReadLine();
            char letter = name.ToLower()[0];
            string group = "";

            if (letter >= 'a' && letter <= 'h')
            {
                group = "A";
            }
            else if (letter >= 'i' && letter <= 'o')
            {
                group = "B";
            }
            else if (letter > 'p' && letter <= 'w')
            {
                group = "C";
            }
            else if (letter >= 'x' && letter <= 'z')
            {
                group = "D";
            }
            else
            {
                group = "Invalid";
            }

            Console.WriteLine($"Username: {name} - Group: {group}");


            Console.Read();
        }
    }
}