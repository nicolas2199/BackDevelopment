//Lo edite desde el git porque no me estaba dejando subir los cambios desde mi PC :)
using System;

namespace PrintPrimes
{
  internal class Program
  {
    static void Main(string[] args)
    {
      PrintPrimes(13);
      // 2,3,5,7,11,13
      PrintPrimes(10);
      // 2,3,5,7
      PrintPrimes(0);
      // Error: Invalid Number
      PrintPrimes(1);
      // Error: 1 Is not Prime

    }

    private static void PrintPrimes(int numberLimit)
    {
     int number=2, divisible=0;
     while (number<=numberLimit)
     {
         if (numberLimit==0)
         {
             Console.WriteLine("Error: Invalid Number");   
         }
         else if (numberLimit==1)
         {
             Console.WriteLine("Error: 1 Is not Prime");    
         }
         else
         {
         for (int i = 1; i < number; i++)
         {
             if (number%i==0)
             {
                 divisible++;
             }
             if (divisible>2)
             {
                 break;
             }
         }
         if (divisible==2)
         {
             Console.WriteLine("{0} es primo",number);    
         }  
         divisible = 0;
         number++;
      }
      Console.ReadKey();
     }
    }
  }
}
