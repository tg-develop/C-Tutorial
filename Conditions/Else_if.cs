using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the keyword: ");
            string key = Console.ReadLine();

            if(key == "K1NG")
            {
                Console.WriteLine("Hello leader");
            }
            else if (key == "M3MB3R")
            {
                Console.WriteLine("Hello member");
            }
            

            Console.Read();
        }
    }
}