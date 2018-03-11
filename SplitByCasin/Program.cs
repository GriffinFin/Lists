using System;
using System.Collections.Generic;

namespace SplitByCasing
{
    internal class Program
    {
        static bool AllLowercase(string word)
        {
            char[] letters = word.ToCharArray();
            bool allLower = true;
            foreach (var letter in letters)
            {

                if (!char.IsLower(letter))
                {
                    allLower = false;
                    break;                   
                }           
            }
            return allLower;
        }

        static bool AllUppercase(string word)
        {
            char[] letters = word.ToCharArray();
            bool allUpper = true;
            foreach (var letter in letters)
            {

                if (!char.IsUpper(letter))
                {
                    allUpper = false;
                    break;                   
                }           
            }
            return allUpper;
        }       
        public static void Main(string[] args)
        {
            char[] delims = new char[] {',', '.', '(', ')', '!', '"', '\'', ':', ';', ']', '[', ' ', '/', '\\'};
            string[] input = Console.ReadLine().Split(delims, StringSplitOptions.RemoveEmptyEntries);
            List<string> uppercase = new List<string>();
            List<string> mixedcase = new List<string>();
            List<string> lowercase = new List<string>();
            foreach (string word in input)
            {
                if (AllUppercase(word))
                {
                    uppercase.Add(word);
                }
                else if (AllLowercase(word))
                {
                    lowercase.Add(word);
                }
                else
                {
                     mixedcase.Add(word);
                }
            }
            Console.WriteLine("Lower-case: " + string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedcase));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercase));
        }
    }
}