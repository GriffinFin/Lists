using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] distinct = input.Distinct().ToArray();
            Array.Sort(distinct);
            foreach (var number in distinct)
            {
                int counter = 0;
                foreach (var target in input)
                {
                    if (number == target)
                    {
                        counter += 1;
                    }
                }

                Console.WriteLine($"{number} -> {counter}");
            }
        }
    }
}