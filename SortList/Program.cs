using System;
using System.Collections.Generic;
using System.Linq;

namespace SortList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<double> sortThis = new List<double>(Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse));
            sortThis.Sort();
            Console.WriteLine(string.Join(" <= ", sortThis));
        }
    }
}