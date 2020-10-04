using System;

namespace csharp_web_dev_exercises_lsn1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive on your trip?");
            string mi = Console.ReadLine();
            int miles = Int32.Parse(mi);

            Console.WriteLine("How many gallons of gas did you use?");
            string gal = Console.ReadLine();
            int gallons = Int32.Parse(gal);

            int mpg = miles / gallons;
            Console.WriteLine("The MPG for the trip was: " + mpg);
        }
    }
}
