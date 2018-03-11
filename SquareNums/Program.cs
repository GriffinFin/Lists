using System;
using System.Collections.Generic;

namespace SquareNums
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            List<int> squareNumbers = new List<int>();
            foreach (var item in numbers)
            {
                if (Math.Sqrt(item)==(int)Math.Sqrt(item))
                {
                    squareNumbers.Add(item);
                }
            }
            squareNumbers.Sort();
            squareNumbers.Reverse();
            Console.WriteLine(string.Join(" ", squareNumbers));
        }
    }
}