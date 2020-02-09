using System;

namespace Application1
{
    class Program
    {
        static void Main(string[] args)
        {
            //100 test calls of our method
            for(int i = 0; i < 100; i++)
            {
                writeRandomColor("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam");
            }
            Console.Read();
        }
        
        //Declaration of the random object outside the method
        //The modifier must be static, because the methods are static and otherwise they can't use the object
        static Random r = new Random();

        //Method to change the foreground color
        static void writeRandomColor(string text)
        {
            var colors = Enum.GetValues(typeof(ConsoleColor));  //Get the list of values of the enumeration
            int colorIndex = r.Next(0, colors.Length);  //Random value between 0 and the length of the console colors

            Console.ForegroundColor = (ConsoleColor)colors.GetValue(colorIndex);    //Change the foreground color to the random value
            Console.WriteLine(text);
        }
    }
}
