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
      if (number <= 0)
      {
        Console.WriteLine("Invalid Number");
      }
      if (number == 1)
      {
        Console.WriteLine("1 Is not Prime");
      }
      for(int i=2 ; i<=number ; i++)
            {
              int primeflag = 0;
                 for(int j=2;j<i;j++)
                  {
                     if(i%j==0)
                       {
                        primeflag = 1;
                        break;
                       }
                  }
                    if(primeflag==0)
                    {
                        Console.WriteLine(i);
                    }
            }
            Console.WriteLine( Environment.NewLine);

  }
  }
}
