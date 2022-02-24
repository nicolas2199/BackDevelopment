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
      
      Console.WriteLine(getPrimesFrom(number));
      
    }

    private static string getPrimesFrom(int number){
      string primesCatch = "";

      if (number == 1)
      {
        return ("Error: 1 Is not Prime");
      }
      if (number <= 0)
      {
        return ("Error: Invalid Number");
      }

      for (int currentNumber = 1; currentNumber <= number; currentNumber++)
      {
        if(validatePrime(currentNumber))
        {
          primesCatch += currentNumber.ToString()+",";
        }
      }
      return primesCatch;
    }

    private static bool validatePrime(int currentNumber){
        
        for (int i = 2; i < currentNumber; i++)
        {
          if(IsDivider(currentNumber,i))
          {
            return false;
          }
        }

      return true;
    }

    private static bool IsDivider(int number, int divider){

      return number % divider == 0;
    }

    //************* old code version *************
    /* private static void PrintPrimes(int number)
    {
      try
      {
        Console.WriteLine(getPrimesFrom(number));
      }
      catch (NotSupportedException e)
      {
        Console.WriteLine(e.Message);
      }
    }

    private static string getPrimesFrom(int number){
      string primesCatch = "";
      const int DividersOfPrime = 2;

      if (number == 1)
      {
        throw new NotSupportedException("Error: 1 Is not Prime");
      }
      if (number <= 0)
      {
        throw new NotSupportedException("Error: Invalid Number");
      }
      for (int currentNumber = 1; currentNumber <= number; currentNumber++)
      {
        int contDivisor = 0;
        for (int i = 1; i <= currentNumber; i++)
        {
          if(currentNumber % i == 0)
          {
            contDivisor += 1;
          }
          if(contDivisor > DividersOfPrime)
          {
            break;
          }
        }
        if(contDivisor == DividersOfPrime)
        {
          primesCatch += currentNumber.ToString()+",";
        }
      }
      return primesCatch;
    } */

    
  }
}

