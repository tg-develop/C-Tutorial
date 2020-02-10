using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Input status code: ");
                int code = Int32.Parse(Console.ReadLine());

                switch (code)
                {
                    case 1: Console.WriteLine("Ok!"); break;
                    case 2: Console.WriteLine("Danger!"); break;
                    case 3: Console.WriteLine("Alarm!"); break;
                    default: Console.WriteLine("Error!"); break;
                }
            }

            Console.Read();
        }
    }
}