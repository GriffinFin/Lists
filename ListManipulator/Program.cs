using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> input = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0]=="print")
                {
                    Console.WriteLine("[" + string.Join(", ", input)+ "]");
                    break;
                }
                else
                {
                    switch (command[0])
                    {
                        case "add":
                            int index = Int32.Parse(command[1]);
                            int num = Int32.Parse(command[2]);
                            input.Insert(index, num);
                            break;
                        case "addMany":
                            int startIndex = Int32.Parse(command[1]);
                            for (int j = 2; j < command.Length; j++)
                            {
                                input.Insert(startIndex, int.Parse(command[j]));
                                startIndex += 1;
                            }
                            break;
                        case "contains":
                        int i = Int32.Parse(command[1]);
                            if (input.Contains(i))
                            {
                                Console.WriteLine(input.IndexOf(i));
                            }
                            else
                            {
                                Console.WriteLine(-1);
                            }
                            break;
                        case "remove":
                            int remove = Int32.Parse(command[1]);
                            input.RemoveAt(remove);
                            break;
                        case "shift":
                            int shifts = int.Parse(command[1]);
                            int[] rotated = new int[input.Count];
                            for (int j = 0; j < input.Count; j++)
                            {
                                rotated[j] = input[(j+(shifts+input.Count))%input.Count];
                            }
                            input.Clear();
                            input = rotated.ToList();
                            break;
                        case "sumPairs":
                            for (int j = 0; j < input.Count - 1; j ++)
                            {
                                input[j] += input[j + 1];
                                input.RemoveAt(j+1);
                            }

                            break;
                    }
                }
            }
        }
    }
}