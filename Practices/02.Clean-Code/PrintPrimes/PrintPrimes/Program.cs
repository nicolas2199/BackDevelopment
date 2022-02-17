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
            int n = 2;
            int total = 1;
            while (total <= 14)
            {
                bool esPrimo = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }

                if (esPrimo)
                {
                    Console.WriteLine(n);
                    total++;
                }
                //se incrementa para evaluar el siguiente número
                n++;
            }
        }
  }
}
