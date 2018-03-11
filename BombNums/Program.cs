using System;
using System.Collections.Generic;

namespace BombNums
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> input = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            int[] bomb = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            while (input.Contains(bomb[0]))
            {
                int index = input.IndexOf(bomb[0]);
                for (int i = 0; i <= 2*bomb[1]; i++)
                {
                    try
                    {
                        input.RemoveAt(Math.Max(0, index-bomb[1]));
                    }
                    catch
                    {
                    }
                }
            }

            int sum = 0;
            foreach (var VARIABLE in input)
            {
                sum += VARIABLE;
            }

            Console.WriteLine(sum);
        }
    }
}