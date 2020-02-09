using System;

namespace Application1
{
    class Program
    {
        const string cornerLeftTop = "┌";
        const string cornerLeftBottom = "└";
        const string cornorRightTop = "┐";
        const string cornorRightBottom = "┘";
        const string borderHorizontal = "─";
        const string borderVertical = "│";

        static void Main(string[] args)
        {
            createBorder();
            Console.Read();
        }

        static void createBorder()
        {
            writeAtPosition(cornerLeftTop, 0, 0);
            writeAtPosition(cornorRightTop, Console.WindowWidth - 1, 0);

            for (int i = 1; i < Console.WindowWidth - 1; i++)
            {
                writeAtPosition(borderHorizontal, i, 0);
                writeAtPosition(borderHorizontal, i, Console.WindowHeight - 1);
            }

            writeAtPosition(cornerLeftBottom, 0, Console.WindowHeight - 1);
            writeAtPosition(cornorRightBottom, Console.WindowWidth - 1, Console.WindowHeight - 1);


            for (int i = 1; i < Console.WindowHeight - 1; i++)
            {
                writeAtPosition(borderVertical, 0, i);
                writeAtPosition(borderVertical, Console.WindowWidth - 1, i);
            }

            Console.SetCursorPosition(0, 0);
        }

        static void writeAtPosition(string text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }
        
        
    }
}
