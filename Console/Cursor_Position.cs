using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft = 3;
            Console.WriteLine("Row 0 - Column 3");

            Console.CursorTop = 3;
            Console.WriteLine("Row 2 - Column 1");

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Row 3 - Column 3");

            Console.Read();
        }
    }
}
