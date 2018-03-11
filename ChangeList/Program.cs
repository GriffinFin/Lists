using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                List<int> input = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
                while (true)
                {
                    string[] commands = Console.ReadLine().Split(' ');
                    string command = commands[0];
                    switch (command.ToLower())
                    {
                        case "delete":
                            int delete = int.Parse(commands[1]);
                            input.RemoveAll(item => item == delete);
                            break;
                        case "insert":
                            int value = int.Parse(commands[1]);
                            int pos = int.Parse(commands[2]);
                            input.Insert(pos, value);
                            break;
                        case "even":
                            foreach (var item in input)
                            {
                                if (item%2==0)
                                {
                                    Console.Write(item + " ");
                                }
                            }
                            break;
                        case "odd":
                            foreach (var item in input)
                            {
                                if (item%2!=0)
                                {
                                    Console.Write(item + " ");
                                }
                            }
                            break;
                    }

                    if (command.ToLower() == "odd"|| command.ToLower() =="even")
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}