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
      if(number == 1)
      {
        Console.Write("Error: 1 Is not Prime\n");
        return;
      }else if(number <= 0)
      {
        Console.Write("Error: Invalid Number\n");
        return;
      }

      for (int i = 1; i <= number; i++)
      {
        if(IsPrime(i))
        {
          Console.Write(i.ToString()+", ");
        }
      }
      Console.Write("\n");

      //throw new NotImplementedException();
    }

    private static bool IsPrime(int number){
      int contDivider = 0;

      for (int i = 1; i <= number; i++)
      {
        if (number % i == 0)
        {
          contDivider += 1;
        }
        if (contDivider>2)
        {
          return false;
        }
      }

      if (contDivider == 2)
      {
        return true;
      }

      return false;
    }
    
  }
}

