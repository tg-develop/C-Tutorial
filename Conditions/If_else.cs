using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input your age: ");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Age is greater 18!");
            } 
            else
            {
                Console.WriteLine("Age is lower 18!");
            }

            Console.Read();
        }


    }
}