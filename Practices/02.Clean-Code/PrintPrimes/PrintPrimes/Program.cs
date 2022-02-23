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
      Console.WriteLine($"PrintPrimes {number}");

      for(int i = 1; i <= number; i++){
        int cont = 0;
        for(int j = 1; j <= i; j++){
          if((i % j) == 0){
            cont ++;
          }
        }

        if(cont == 2){
          Console.Write($"{i}, ");
        }
      }

      if(number == 0){
        Console.WriteLine("Error: Invalid Number");
      }

      if(number == 1){
        Console.WriteLine("Error: 1 Is not Prime");
      }
      Console.WriteLine();
    }
  }
}
