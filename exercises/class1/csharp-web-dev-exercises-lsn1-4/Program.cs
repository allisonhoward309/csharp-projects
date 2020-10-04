using System;

namespace csharp_web_dev_exercises_lsn1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine(alice);
            Console.WriteLine("What sentence would you like to look for in the sentence above?");
            string searchTerm = Console.ReadLine();
            string compSearchTerm = searchTerm.ToLower();
            string compAlice = alice.ToLower();

            int foundIndex = compAlice.IndexOf(compSearchTerm, 0);
            Console.WriteLine("The search term, " + searchTerm + ", can be found at index " + foundIndex + ".");
            Console.WriteLine("The search term is " + searchTerm.Length + " characters long.");

            string newAlice = alice.Remove(foundIndex, searchTerm.Length);
            Console.WriteLine(newAlice);

            // Console.WriteLine(compAlice.Contains(compSearchTerm));
        }
    }
}
