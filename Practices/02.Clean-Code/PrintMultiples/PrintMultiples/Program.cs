using System;

namespace PrintMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(1);
        }

        private static void PrintNumbers(int number)
        {
            for(int numberCounter = number; numberCounter <= 100; numberCounter++)
            {
                if(numberCounter%5==0){
                 Console.Write("M-5, ");
                }
                else if(numberCounter%3==0){
                 Console.Write("M-3, ");
                }
                else if(numberCounter%15==0){
                 Console.Write("M-3-5, ");
                }
                else{
                 Console.Write(numberCounter+", ");
                } 
            }
        }
    }    
}