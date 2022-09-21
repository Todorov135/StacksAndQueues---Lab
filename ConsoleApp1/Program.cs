using System;

namespace overview
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= lines; i++)
            {
                Console.WriteLine($"Vlizane v pyrvi cikyl {i}");
                for (int j = 0; j < lines; j++)
                {
                    Console.WriteLine($"Vyrti se wtoriq cikyl{j}");
                }
                Console.WriteLine($"-------------------------");
            }
           
           
        }
    }
}