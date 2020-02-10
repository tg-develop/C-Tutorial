using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input random number: ");
            int number = Int32.Parse(Console.ReadLine());

            if (number % 2 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes! True");
            }
            else
            {
                Console.WriteLine("No, false!");
            }


            Console.Read();
        }
    }
}