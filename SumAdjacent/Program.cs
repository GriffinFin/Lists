using System;
using System.Collections.Generic;
using System.Linq;

namespace SumAdjacent
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<double> intList = new List<double>(Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse));
            bool exist = true;
            while (exist)
            {
                exist = false;
                for (double i = 0; i < intList.Count-1; i++)
                {
                    if (intList[(int)i]==intList[(int)i+1])
                    {
                        intList[(int)i] += intList[(int)i+1];
                        intList.RemoveAt((int)i+1);
                        exist = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", intList));
        }
    }
}