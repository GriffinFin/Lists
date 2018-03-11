using System;
using System.Collections.Generic;

namespace RemoveAndReverse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list =new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse)) ;
            list.RemoveAll(Negative);
            list.Reverse();
            if (list.Count==0)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
        }

        static bool Negative(int a)
        {
            return a < 0;
        }
    }
}