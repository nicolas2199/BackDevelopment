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
            Console.Write(getNumbersUntil(number));
        }

        private static string getNumbersUntil(int number)
        {
            string ListNumbers = "";
            for (int i = 1; i <= number; i++)
            {
                //ListNumbers += isMultiple(i , 3) ? isMultiple(i , 5) ? (M-3-5)+"" : (M-3)+"" : isMultiple(i , 5) ? (M-5)+"" : (i)+"";

                if(isMultiple(i , 3))
                {

                    if(isMultiple(i , 5))
                    {
                        ListNumbers += "M-3-5";
                    }else{
                        ListNumbers += "M-3";
                    }

                }else if(isMultiple(i , 5))
                {

                    ListNumbers += "M-5";

                }else{

                    ListNumbers += (i)+"";

                }

                ListNumbers += i == number ? ".": ",";
            }

            return ListNumbers;
        }

        private static bool isMultiple(int number, int multiple)
        {
            return (number % multiple == 0);
        }

        /************** version 0.1 ************
        /* private static void PrintMultiples(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if(i % 3 == 0){
                    if(i % 5 == 0){
                        Console.Write($"c3:{i-3-5},");
                    }
                    else
                    {
                        Console.Write($"c1:{i-3},");
                    }
                }
                else if(i % 5 == 0){
                    Console.Write($"c2:{i-5},");
                }
                else{
                    Console.Write($"c0:{i},");
                }
            }
        } */
        /************** version 0.1 ************/
    }
}
