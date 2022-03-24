//Juan Felipe Osorio 64740

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


    private static void PrintPrimes(int number)
    {
      if (number == 0)
    {
        Console.WriteLine("Error: Invalid Number.");
    }
    else if (number == 1)
    {
        Console.WriteLine("Error: 1 Is not Prime.");
    }
      else{
        int numberCounter = 0;
        for (int i = 2; i <= number; i++){  
          for (int j = 1; j <= i; j++){
             if (i % j == 0){ 
                numberCounter = numberCounter + 1;
               }
            }
         if (numberCounter <= 2){ 
           Console.Write(i + ", ");
          }
         numberCounter = 0;
         }
         Console.WriteLine();
      }
    }
  }
}