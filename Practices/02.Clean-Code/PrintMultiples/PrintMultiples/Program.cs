using System;

namespace PrintMultiples
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrintMultiples();

            
        }

        private static void PrintMultiples()
        {
            bool isMultiple;

            for(int i = 1; i <= 100; i++)
            {
                isMultiple = false;

                if(i%3 == 0)
                {
                    isMultiple = true;
                }

                if(isMultiple == true)
                {
                    Console.WriteLine("M-3");
                    isMultiple = true;
                } else {
                    Console.WriteLine(i);
                    isMultiple = false;
                }
            }
        }
    }
}
