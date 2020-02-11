using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool input = true;
            int sum = 0;

            while(input)
            {
                Console.Write("Enter number: ");
                sum += Int32.Parse(Console.ReadLine());

                Console.Write("Enter more number? (y / n): ");

                if(Console.ReadLine() == "n")
                {
                    input = false;
                }
            }

            Console.WriteLine($"Sum: {sum}");


            Console.Read();
        }
    }
}