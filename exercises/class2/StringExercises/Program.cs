using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. For this exercise, use the string ``I would not, could not, in a box. I
            // would not, could not with a fox. I will not eat them in a house. I will not
            // eat them with a mouse.`` 
            string str = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse.";
            // 2. Use the ``Split`` method to divide the string at each space and store the
            // individual words in an array.
            string[] words = str.Split(" ");
            // 3. Print the array of words to verify that your code works.
            Console.WriteLine(string.Join("/", words));
            // 4. Repeat steps 3 and 4, but change the delimiter to split the string into separate sentences.
            string[] sentences = str.Split(".");
            // 3. Print the array of words to verify that your code works.
            Console.WriteLine(string.Join("/", sentences));
        }
    }
}
