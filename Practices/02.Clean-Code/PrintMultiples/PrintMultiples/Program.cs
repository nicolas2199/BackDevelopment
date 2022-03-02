using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiples(100);
        }

        //write a program (c#) that prints the numbers from 1 to 100
        //but for multiples of three print, "M-3" instead of the number and
        //for the multiples of five print "M-5"
        //For number wich are multiples of both three and five print "M-3-5"  


        private static void PrintMultiples(int number)
        {
            int resultTotal = 0;
            for (int currentNumber = 1; currentNumber <=number; currentNumber++)
            {
                if(IsMultiple3(currentNumber)==resultTotal && IsMultiple5(currentNumber)==resultTotal)
                {
                    Console.WriteLine("M-3-5");
                    // PrintResultMultiple(currentNumber);
                }
                else if(IsMultiple3(currentNumber)==resultTotal)
                {
                    Console.WriteLine("M-3");
                    // PrintResultMultiple();
                }
                else 
                if(IsMultiple5(currentNumber)==resultTotal)
                {
                    Console.WriteLine("M-5");
                    // PrintResultMultiple(currentNumber);
                }
                else
                {
                    Console.WriteLine(currentNumber);
                }
                
            }
        }
        
        private static int IsMultiple3(int currentNumber)
        {
            int resultMultiple = currentNumber%3;
            return resultMultiple;
        }

        private static int IsMultiple5(int currentNumber)
        {
            int resultMultiple = currentNumber%5;
            return resultMultiple;
        }

        // private static void PrintResultMultiple(int currentNumber)
        // {
        //     if(IsMultiple3(currentNumber)==0 && IsMultiple5(currentNumber)==0)
        //     {
        //         return Console.WriteLine("M-3-5");
        //     }
        //     else if (IsMultiple3(currentNumber)==0)
        //     {
        //         return Console.WriteLine("M-3");
        //     }
        //     else if (IsMultiple5(currentNumber)==0)
        //     {
        //         return Console.WriteLine("M-5");
        //     }
        // }
    }
}
