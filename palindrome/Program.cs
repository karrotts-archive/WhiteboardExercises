using System;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palindromes
            Console.WriteLine(IsPalindrome("Anna"));
            Console.WriteLine(IsPalindrome("Civic"));


            // Non-palindromes
            Console.WriteLine(IsPalindrome("Tacos"));
            Console.WriteLine(IsPalindrome("Dogs"));

            Console.WriteLine("Please input a word or phrase: ");
            string input = Console.ReadLine();
            while (input != "")
            {
                Console.WriteLine(IsPalindrome(input) ? $"\"{input}\" is a palindrome!" : $"\"{input}\" is not a plaindrome.");
                Console.WriteLine("Please input a word or phrase: ");
                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            string backwards = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                backwards += word[i];
            }
            return backwards == word;
        }
    }
}
