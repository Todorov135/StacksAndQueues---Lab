using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> savedIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                if (currChar == '(')
                {
                    savedIndexes.Push(i);

                }
                else if (currChar == ')')
                {
                    int startIndex = savedIndexes.Pop();
                    int endIndex = i;
                    string substring = input.Substring(startIndex, endIndex - startIndex+1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
