using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiples(100);
        }

        private static void PrintMultiples(int number)
        {
            for (int i = 1; i < number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
