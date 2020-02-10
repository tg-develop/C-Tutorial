using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Below 18 years old");
            }
            else if (age < 31)
            {
                Console.WriteLine("Between 18 and 30 years old");
            }
            else if (age < 51)
            {
                Console.WriteLine("Between 31 and 50 years old");
            }
            else
            {
                Console.WriteLine("Not Matched!");
            }

            Console.Read();
        }
    }
}