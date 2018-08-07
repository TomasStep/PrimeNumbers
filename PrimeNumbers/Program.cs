using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    internal class Program
    {
        private static void PrintInfo(IReadOnlyCollection<int> iList)
        {
            Console.WriteLine("Do you want to print all prime numbers?");
            Console.WriteLine("primeList length " + iList.Count);
            Console.WriteLine("Y/N or y/n");
            var print = Console.ReadLine();
            if (print == "Y" || print == "y")
            {
                Console.WriteLine("All Prime numbers:");
                foreach (int prime in iList)
                {
                    Console.Write(prime + " ");
                }Console.WriteLine();
            }
            else
                Console.WriteLine("Print aborted!");
        }

        private static void PrimeNumbers(int numbers, List<int> pList)
        {
            for (var i = 2; i <= numbers; i++)
            {
                var count = 0;
                for (var j = 2; j < numbers; j++)
                {
                    if (i >= j && i % j == 0)
                    {
                        count++;
                    }
                }
                if (count <= 1)
                    pList.Add(i);
            }
        }

        private static int Intro()
        {
            Console.WriteLine("Insert a number to start prime number search\nProgram will search all prime numbers from 0 to n (your choice)");
            Console.Write("n = ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered {n}");
            return n;
        }

        private static void Main()
        {
            int number = Intro();
            List<int> primeList = new List<int>();
            PrimeNumbers(number, primeList);
            PrintInfo(primeList);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
