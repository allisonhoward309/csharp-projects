using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Within ``Main``, create a list with at least 10 integers and call your method on the list.
            List<int> someIntegers = new List<int>();
            someIntegers.Add(1);
            someIntegers.Add(2);
            someIntegers.Add(3);
            someIntegers.Add(4);
            someIntegers.Add(5);
            someIntegers.Add(6);
            someIntegers.Add(33);
            someIntegers.Add(42);
            someIntegers.Add(101);
            someIntegers.Add(1138);
            Console.WriteLine(sumEven(someIntegers));

            string phrase = "I would not could not in a box";
            List<string> wordList = new List<string>();
            string[] newStr = phrase.Split(" ");
            foreach(string word in newStr)
            {
                wordList.Add(word);
            }

            // 3. test the method
            printFiveLetterWords(wordList);

            // 4. test the method
            // Prompt the user for a word length:
            Console.WriteLine("Enter a word length: ");
            string numInput = Console.ReadLine();
            int numChars = int.Parse(numInput);

            // Call the method to print out list words of the chosen length:
            printXLetterWords(wordList, numChars);

        }

        // 1. Write a static method to find the sum of all the even numbers in a List. 
        public static int sumEven(List<int> arr)
        {
            int total = 0;
            foreach (int integer in arr)
            {
                if (integer % 2 == 0)
                {
                    total += integer;
                }
            }
            return total;
        }

        // 3. Write a static method to print out each word in a list that has exactly 5 letters.
        public static void printFiveLetterWords(List<string> wordlist)
        {
            foreach (string word in wordlist)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }

        // 4. Modify your code to prompt the user to enter the word length for the search.
        public static void printXLetterWords(List<string> wordlist, int length)
        {
            foreach (string word in wordlist)
            {
                if (word.Length == length)
                {
                    Console.WriteLine(word);
                }
            }
        }


    }
}
