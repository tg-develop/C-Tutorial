using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            centerText("Hello");
            centerText("What's up");
            Console.Read();
        }

        static void centerText(string text)
        {
            Console.CursorLeft = Console.BufferWidth / 2 - text.Length / 2;
            Console.WriteLine(text);
        }
    }
}
