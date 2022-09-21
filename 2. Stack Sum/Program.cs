using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputedIntigers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Stack<int> stack = new Stack<int>(inputedIntigers);

            string command = "";
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "add":
                        {
                            int numb1 = int.Parse(tokens[1]);
                            int numb2 = int.Parse(tokens[2]);
                            stack.Push(numb1);
                            stack.Push(numb2);
                        }
                        break;
                    case "remove":
                        {
                            int integersToRemove = int.Parse(tokens[1]);
                            if (integersToRemove <= stack.Count)
                            {
                                for (int i = 0; i < integersToRemove; i++)
                                {
                                    stack.Pop();
                                }
                            }
                        }
                        break;
                      
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");

        }
    }
}
