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
      int n = 2;

        
      while(n <= number){

            
        bool esPrimo = true;

            
        for (int i = 2; i < n; i++) {
            if(n % i == 0)
            {
              esPrimo = false;
              break;
           }

          }

            
          if(esPrimo)
          {
           Console.WriteLine(n);
          }
            
          n++;

        }
      switch (number){
        case 0:
          Console.WriteLine("Invalid Number");
          break;
        case 1:
          Console.WriteLine("Is not prime");
          break;
      }    
    }
  }
}