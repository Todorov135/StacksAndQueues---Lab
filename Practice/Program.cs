using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string[] expressionChar = expression.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> expressionStack = new Stack<string>(expressionChar.Reverse());

            int sum = int.Parse(expressionStack.Pop());

            while (expressionStack.Count >0)
            {
                if (expressionStack.Peek() == "-")
                {
                    expressionStack.Pop();
                    int currNum = int.Parse(expressionStack.Pop());
                    sum -= currNum;
                }
                else if (expressionStack.Peek() == "+")
                {
                    expressionStack.Pop();
                    int currNum = int.Parse(expressionStack.Pop());
                    sum += currNum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

      
