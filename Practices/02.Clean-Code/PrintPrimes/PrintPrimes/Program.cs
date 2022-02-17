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
      /* Console.WriteLine("Hello sFeZ"); */

      int contador = 0; 
      for (int i = 2; i <= 13; i++){ 

        for (int j = 1; j <= i; j++){   
 
          if (i % j == 0){ 
            contador = contador + 1;
          }

        }
    
        if (contador <= 2){ 
          Console.WriteLine(i);
        }      
        contador = 0; 
    
    
      }
  
      Console.ReadKey();
    }
  }
}
