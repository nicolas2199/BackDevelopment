using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static void PrintMultiples(int number){
            for(int i = 0; i < 100; i++){
                Console.WriteLine(i);
            }
        }
    }
}
