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
      Console.WriteLine("Real World");
      //Loop to iterate until the number
        //validate is the index is Prime
          //Loop from 2 number
            //validate if multipleOf
              //return True =>> Not Prime
            //If is Prime
              //Write Number
    }
  }
}
