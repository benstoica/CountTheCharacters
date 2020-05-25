using System;

namespace CountTheCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter the word you would like to know the length of.");
                string userWord = Console.ReadLine();
                while (string.IsNullOrEmpty(userWord))
                {
                    Console.WriteLine("You have to enter a word! Please enter the word you would like to know the length of.");
                    userWord = Console.ReadLine();
                }
                int wordLength = userWord.Length;
                Console.WriteLine($"{userWord} has {wordLength} characters.");

                Console.WriteLine("Would you like to know the length of another word? (Y/N)");
                string checkAnother = Console.ReadLine().ToUpper();
                if (checkAnother == "Y")
                {
                    continue;
                }

                else if (checkAnother == "N")
                {
                    Console.WriteLine("Thank you! Have a great day!");
                    return;
                }
            }
        }
    }
}
