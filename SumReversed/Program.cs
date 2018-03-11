using System;
using System.Linq;

namespace SumReversed
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            foreach (var num in input)
            {
                char[] current = num.ToCharArray();
                string currentS = string.Join("", current.Reverse());
                sum += int.Parse(currentS);
            }

            Console.WriteLine(sum);
        }
    }
}