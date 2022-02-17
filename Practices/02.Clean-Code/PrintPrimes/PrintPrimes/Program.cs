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
      Console.WriteLine("hola");
      //loop to iterate until the number
        //Validate is the index is prime
          //loop from 2 to number
            // validate if multipleof
              //return True => not prime
            // is IsPrime
              //Write number
    }
  }
}
