using System;

namespace csharp_web_dev_exercises_lsn1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your rectangle?");
            string length = Console.ReadLine();
            int rectangleLength = Int32.Parse(length);
            Console.WriteLine("The length of the rectangle is: " + rectangleLength);

            Console.WriteLine("What is the width of your rectangle?");
            string width = Console.ReadLine();
            int rectangleWidth = Int32.Parse(width);
            Console.WriteLine("The width of the rectangle is: " + rectangleWidth);

            int area = rectangleWidth * rectangleLength;
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}
