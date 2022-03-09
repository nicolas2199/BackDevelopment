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
     //loop to iterate until the number
        //Validate is the index is prime
          //loop from 2 to number
            // validate if multipleof
              //return True => not prime
            // is IsPrime
              //Write number

    private static void PrintPrimes(int number)
    {
      for (int i = 1; i <= number; i++){
        int contPrimes = 0;
          for (int j = 1; j <= i; j++)
          {
            if (i % j == 0)
            {
              contPrimes++;
            }
          }
        if (contPrimes == 2)
        {
          Console.Write(i);
          Console.Write(", ");
        }
      }
      Console.WriteLine();
        if (number == 0)
        {
          Console.Write("Error: Invalid Number");
        }
        if (number == 1)
        {
          Console.Write("1 Is not Prime");
        }
    }//PrintPrimes
  }

  /* private bool IsMultipleOg(int number, int baseMultiple)
  {
    return number % baseMultiple 
  } */
}
