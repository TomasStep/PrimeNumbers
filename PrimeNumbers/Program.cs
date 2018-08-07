using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    class Program
    {
        static void printInfo(List<int> iList)
        {
            string print;
            Console.WriteLine("Do you want to print all prime numbers?");
            Console.WriteLine("primeList length " + iList.Count);
            Console.WriteLine("Y/N or y/n");
            print = Console.ReadLine();
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

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
        static void primeNumbers(int numbers, List<int> pList)
        {
            int count = 0;
            for (int i = 2; i <= numbers; i++)
            {
                count = 0;
                for (int j = 2; j < numbers; j++)
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
        static int intro()
        {
            int n = 0;
            Console.WriteLine("Insert a number to start prime number search\nProgram will search all prime numbers from 0 to n (your choice)");
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You entered {n}");
            return n;
        }
        static void Main(string[] args)
        {
            int number = intro();
            List<int> primeList = new List<int>();
            primeNumbers(number, primeList);
            printInfo(primeList);
        }
    }
}
