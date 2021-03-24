using System;
using System.Linq;
using System.Collections.Generic;

namespace StringReversal
{
    class Program
    {
        public static string reverse(string input)
        {
            int index = 0; //Tracking the index as we iterate over the input
            string word = "";
            Stack<char> wordStack = new Stack<char>();

            while (index < input.Length) 
            {
                for (int i = index; i < input.Length; i++)
                {
                    if (input[i] == ' ') break; //Exit the loop if we encounter a whitespace character
                    ++index;
                    wordStack.Push(input[i]);
                }
                
                while (wordStack.Count > 0) word += wordStack.Pop(); //Add to the word by taking characters off the top of the stack

                word += ' '; //Add the whitespace character to the word
                ++index; //Incrementing the index to ignore the whitespace character from the input
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

            if (checkString(input) == false) Console.WriteLine("Please only use alphabetical characters."); //The user's input contains non-alphabetical characters
            
            else Console.WriteLine($"Your word/phrase reversed is: {reverse(input)}\n"); //The user's input contains only alphabetical characters (a-z, A-Z)
        }
    }
}
