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
            

        }

    private static void PrintPrimes(int number)
    {
            //throw new NotImplementedException();
            bool isPrime = true;
            try
            {
                if (number == 1)
                {
                    Console.WriteLine("Error: Invalid Number");
                }

                if (number == 0)
                {
                    Console.WriteLine("Error: Invalid Number");
                }

                for (int i = 2; i <= number; i++)
                {
                    for (int j = 2; j <= number; j++)
                    {
                        if (i != j && i % j == 0 || i == 1)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                   
                        if (isPrime)
                        {
                        
                            Console.WriteLine("Prime:" + i);
                        
                            
                        }
                    isPrime = true;
                }
            }
            catch(Exception e)
            {
                
            }
            
        }
  }
}
