using System;

// A palindrome is a word that reads the same backward or forward.
// Write a function that checks if a given word is a palindrome.Character case should be ignored.
// For example, IsPalindrome("Deleveled") should return true as character case should be ignored, resulting in "deleveled", 
// which is a palindrome since it reads the same backward and forward.

namespace Palindrome
{

    class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            char[] wordArray = word.ToLower().ToCharArray();
            Array.Reverse(wordArray);
            string backwardWord = new string(wordArray);
            return word.ToLower() == backwardWord;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("Deleveled"));
        }
    }
}
