using System;
using System.Collections.Generic;

namespace StringReversal
{
    class Program
    {
        public static string reverse(string input)
        {
            string word = "";
            Stack<char> wordStack = new Stack<char>();

            for (int i = 0; i <= input.Length; i++) //Tracking the current index as we iterate over the input 
            {
                if (i == input.Length || input[i] == ' ') //Empty the stack and ignore any whitespace characters
                {
                    while (wordStack.Count > 0) word += wordStack.Pop();
                    word += ' '; //Add the previously ignored whitespace character to the word
                    continue; 
                }

                wordStack.Push(input[i]);
            }
            return word;
        }

        private static bool checkString(string word)
        {
            foreach (char letter in word)
            {
                if (letter == ' ') continue; //Ignoring the whitespace characters

                if (!Char.IsLetter(letter)) return false; //Validating the individual chracters in the word
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a word or phrase to reverse: ");
            string input = Console.ReadLine();

            if (checkString(input) == false) //The user's input contains non-alphabetical characters
            {
                Console.WriteLine("Please only use alphabetical characters."); 
            }
            else //The user's input contains only alphabetical characters (a-z, A-Z)
            {
                Console.WriteLine($"Your word/phrase reversed is: {reverse(input)}\n"); 
            }
       }
        
    }
}
