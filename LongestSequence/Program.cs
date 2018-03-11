using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestSequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int max = 0;
            int maxCount = 0;
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);          
            List<List<int>> sequences = new List<List<int>>();
            sequences.Add(new List<int>(){input[0]});
            for (int i = 1; i < input.Length; i++)
            {
                bool hasNotBeenAdded = true;
                for (int j = 0; j < sequences.Count; j++)
                {
                    if (sequences[j][sequences[j].Count-1]<input[i])
                    {
                        sequences.Add(new List<int>());
                        sequences[sequences.Count-1].AddRange(sequences[j]);
                        sequences[sequences.Count-1].Add(input[i]);
                        if (sequences[sequences.Count-1].Count>maxCount)
                        {
                            max = sequences.Count - 1;
                            maxCount = sequences[sequences.Count - 1].Count;
                        }
                    }
                    else if (hasNotBeenAdded)
                    {
                        sequences.Add(new List<int>(){input[i]});
                        hasNotBeenAdded = false;
                    }
                }              
            }
            Console.WriteLine(string.Join(" ", sequences[max]));
        }
    }
}