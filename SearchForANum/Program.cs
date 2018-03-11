using System;
using System.Collections.Generic;

namespace SearchForANum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> inputInts = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            int[] commands = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int get = commands[0];
            while (get<inputInts.Count)
            {
                inputInts.RemoveAt(get);
            }
            inputInts.RemoveRange(0, commands[1]);
            if (inputInts.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}