using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] players = Console.ReadLine().Split();
            int step = int.Parse(Console.ReadLine());
            Queue<string> queuedPlayers = new Queue<string>(players);


            while (queuedPlayers.Count > 1)
            {

                for (int i = 1; i < step; i++)
                {
                        
                    queuedPlayers.Enqueue(queuedPlayers.Dequeue());
                }
                Console.WriteLine($"Removed {queuedPlayers.Dequeue()}");
            }
            Console.WriteLine($"Last is {queuedPlayers.Peek()}");
        }
    }
}
