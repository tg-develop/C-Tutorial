using System;
using System.Linq;
using System.Collections.Generic;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the price of your purchase: ");
            double price = Double.Parse(Console.ReadLine());
            double discout = 0;

            if (price >= 500)
                discout = 0.4;
            else if (price >= 200)
                discout = 0.25;
            else if (price >= 100)
                discout = 0.1;

            double newPrice = price * (1.0 - discout);

            Console.WriteLine($"Old Price: {price} - Discount percent: {discout * 100}% - New Price: {newPrice}");


            Console.Read();
        }
    }
}