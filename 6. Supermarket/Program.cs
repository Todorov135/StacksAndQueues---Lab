using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    int customersOnQueue = customers.Count;
                    for (int i = 0; i < customersOnQueue; i++)
                    {
                        Console.WriteLine(customers.Peek());
                        customers.Dequeue();
                    }

                }
                else
                {
                    customers.Enqueue(command);
                }

            }
            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
