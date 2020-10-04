using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create and initialize an array with the following values in a single line: ``1, 1, 2, 3, 5, 8``.
            int[] integerArray = { 1, 1, 2, 3, 5, 8 };

            // 2. Loop through the array and print out each value. 
            foreach (int integer in integerArray)
            {
                Console.WriteLine(integer);
            }

            // 3. Modify the loop to only print the odd numbers from the array.
            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] % 2 != 0)
                {
                    Console.WriteLine(integerArray[i]);
                }
            }


        }
    }
}
