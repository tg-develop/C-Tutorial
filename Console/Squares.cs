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
            createBorder(5, 5, 20, 10);
            createBorder(10, 20, 10, 5);
            createBorder(40, 12, 16, 8);

            Console.Read();
        }

        static void createBorder(int xStart, int yStart, int width, int height)
        {
            writeAtPosition(cornerLeftTop, xStart, yStart);
            writeAtPosition(cornorRightTop, xStart + width - 1, yStart);

            for (int i = 1; i < width - 1; i++)
            {
                writeAtPosition(borderHorizontal, xStart + i, yStart);
                writeAtPosition(borderHorizontal, xStart + i, yStart + height - 1);
            }

            writeAtPosition(cornerLeftBottom, xStart, yStart + height - 1);
            writeAtPosition(cornorRightBottom, xStart + width - 1, yStart + height - 1);


            for (int i = 1; i < height - 1; i++)
            {
                writeAtPosition(borderVertical, xStart, yStart + i);
                writeAtPosition(borderVertical, xStart + width - 1, yStart + i);
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
