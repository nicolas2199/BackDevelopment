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

      switch (number){
        case 0:
          Console.WriteLine("Invalid Number");
          break;
        case 1:
          Console.WriteLine("Is not prime");
          break;
      } 

      
    
      int currentNumber = 2;

        
      while(currentNumber <= number){

            
        bool esPrimo = true;

            
        for (int baseMultiple = 2; baseMultiple < currentNumber; baseMultiple++) {
            if(IsMultiple(currentNumber, baseMultiple))
            {
              esPrimo = false;
              break;
           }

          }
          if(esPrimo)
          {
           Console.WriteLine(currentNumber);
          }
            
          currentNumber++;

        }
    }
  
  public static bool IsMultiple(int currentNumber, int baseMultiple)
  {
    return currentNumber % baseMultiple == 0;
  }
  private static bool isPrime(int currentNumber)
  {
    
    return true;
  }
  }
}
