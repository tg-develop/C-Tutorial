using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The method WriteLine adds automatically an line break at the end of the text.
            //It's also possible to write \n inside the text to add a line break.

            //The method Write can be used to output text. 
            //There are no line breaks, the next Write statement will continuous writing in the same line.

            Console.WriteLine("Output 1");
            Console.Write("Output 2 ");
            Console.Write("Output 3\n");
            Console.WriteLine("Output 4");

            Console.Read();
        }
    }
}
