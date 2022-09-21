using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expressions = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(expressions.Reverse());
            int result = int.Parse(stack.Pop());

            while (stack.Count>0)
            {
                
                string operation = stack.Pop();
                if (operation == "+")
                {
                    result += int.Parse(stack.Pop());
                }
                else if (operation == "-")
                {
                    result -= int.Parse(stack.Pop());
                }

            }
            Console.WriteLine(result);

        }
    }
}
