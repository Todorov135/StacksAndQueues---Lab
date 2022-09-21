using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passingCars = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int passingCarCounter = 0;
            string car = string.Empty;

            while ((car = Console.ReadLine()) != "end")
            {
                if (car == "green")
                {
                    if (carsQueue.Count < passingCars)
                    {
                        passingCars = carsQueue.Count;
                    }
                    for (int i = 0; i < passingCars; i++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        passingCarCounter++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(car);
                }
            }
            Console.WriteLine($"{passingCarCounter} cars passed the crossroads.");
        }
    }
}
