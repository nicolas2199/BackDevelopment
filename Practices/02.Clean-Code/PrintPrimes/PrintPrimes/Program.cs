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

    private static void PrintPrimes(int number){
      
      if (number==0){
        Console.WriteLine ("-------------------------------------------");
        Console.WriteLine ("| ERROR: The numer "+"0"+" its a invalid number |");
        Console.WriteLine ("-------------------------------------------");
      }

      else if (number==1){
        Console.WriteLine ("| ERROR: The number "+"1"+" is not prime |");
        Console.WriteLine ("------------------------------------");
      }

      else{
        Console.WriteLine("----------------------------");
        int cont = 0;
        for (int i = 2; i <= number; i++){  

          for (int j = 1; j <= i; j++){
            if (i % j == 0){ 
              cont = cont + 1;
            }
          }

          if (cont <= 2){ 
              Console.WriteLine("|            "+i+"             |");
          }

          cont = 0;
    
        }

      }
  
      Console.ReadKey();

    }

  }

}
