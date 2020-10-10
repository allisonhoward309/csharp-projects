using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student sally = new Student("Sally", 1, 1, 4.0);
            Console.WriteLine("The Student class works! " + sally.Name + " is a student!");
            Console.WriteLine(sally);
            sally.AddGrade(12, 3.5);
            Console.WriteLine(sally);
            sally.AddGrade(25, 3.8);
            Console.WriteLine(sally);
        }
    }
}
